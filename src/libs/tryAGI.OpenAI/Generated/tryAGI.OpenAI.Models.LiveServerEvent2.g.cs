#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An event sent by the Live API on a primary WebSocket or sideband connection.
    /// </summary>
    public readonly partial struct LiveServerEvent2 : global::System.IEquatable<LiveServerEvent2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType? Type { get; }

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
        /// Input audio received from the primary transport and reflected to a Live sideband connection before model-input muting.<br/>
        /// Example: {"type":"session.input_audio.append","audio":"AACAAIAAAIAAAP9/AIAAgA=="}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveInputAudioAppend? SessionInputAudioAppend { get; init; }
#else
        public global::tryAGI.OpenAI.LiveInputAudioAppend? SessionInputAudioAppend { get; }
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
            out global::tryAGI.OpenAI.LiveInputAudioAppend? value)
        {
            value = SessionInputAudioAppend;
            return IsSessionInputAudioAppend;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveInputAudioAppend PickSessionInputAudioAppend() => IsSessionInputAudioAppend
            ? SessionInputAudioAppend!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionInputAudioAppend' but the value was {ToString()}.");

        /// <summary>
        /// An audio chunk generated by the Live model. Decode and play primary WebSocket chunks in delivery order using the configured session audio format. Sideband connections receive reflected output audio with timestamps.<br/>
        /// Example: {"type":"session.output_audio.delta","delta":"AACAAIAAAIAAAP9/AIAAgA==","start_ms":1000,"end_ms":1200}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveOutputAudioDelta? SessionOutputAudioDelta { get; init; }
#else
        public global::tryAGI.OpenAI.LiveOutputAudioDelta? SessionOutputAudioDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionOutputAudioDelta))]
#endif
        public bool IsSessionOutputAudioDelta => SessionOutputAudioDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSessionOutputAudioDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::tryAGI.OpenAI.LiveOutputAudioDelta? value)
        {
            value = SessionOutputAudioDelta;
            return IsSessionOutputAudioDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveOutputAudioDelta PickSessionOutputAudioDelta() => IsSessionOutputAudioDelta
            ? SessionOutputAudioDelta!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SessionOutputAudioDelta' but the value was {ToString()}.");

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
        public global::tryAGI.OpenAI.LiveTransportDTMFReceived PickTransportDtmfReceived() => IsTransportDtmfReceived
            ? TransportDtmfReceived!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransportDtmfReceived' but the value was {ToString()}.");

        /// <summary>
        /// A SIP DTMF keypress successfully sent by the hosted tool. Delivered only to sideband observers; this is not a client command.<br/>
        /// Example: {"type":"transport.dtmf.send","event_id":"event_dtmf_2","event":"#"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::tryAGI.OpenAI.LiveTransportDTMFSend? TransportDtmfSend { get; init; }
#else
        public global::tryAGI.OpenAI.LiveTransportDTMFSend? TransportDtmfSend { get; }
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
            out global::tryAGI.OpenAI.LiveTransportDTMFSend? value)
        {
            value = TransportDtmfSend;
            return IsTransportDtmfSend;
        }

        /// <summary>
        ///
        /// </summary>
        public global::tryAGI.OpenAI.LiveTransportDTMFSend PickTransportDtmfSend() => IsTransportDtmfSend
            ? TransportDtmfSend!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransportDtmfSend' but the value was {ToString()}.");

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
        public global::tryAGI.OpenAI.LiveTransportRinging PickTransportRinging() => IsTransportRinging
            ? TransportRinging!
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
        public global::tryAGI.OpenAI.LiveTransportAnswered PickTransportAnswered() => IsTransportAnswered
            ? TransportAnswered!
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
        public global::tryAGI.OpenAI.LiveTransportFailed PickTransportFailed() => IsTransportFailed
            ? TransportFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransportFailed' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveSessionStarted value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveSessionStarted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionStarted?(LiveServerEvent2 @this) => @this.SessionStarted;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveSessionStarted? value)
        {
            SessionStarted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromSessionStarted(global::tryAGI.OpenAI.LiveSessionStarted? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveSessionUpdated value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveSessionUpdated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionUpdated?(LiveServerEvent2 @this) => @this.SessionUpdated;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveSessionUpdated? value)
        {
            SessionUpdated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromSessionUpdated(global::tryAGI.OpenAI.LiveSessionUpdated? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveInputAudioMuted value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveInputAudioMuted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInputAudioMuted?(LiveServerEvent2 @this) => @this.SessionInputAudioMuted;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveInputAudioMuted? value)
        {
            SessionInputAudioMuted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromSessionInputAudioMuted(global::tryAGI.OpenAI.LiveInputAudioMuted? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveInputAudioUnmuted value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveInputAudioUnmuted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInputAudioUnmuted?(LiveServerEvent2 @this) => @this.SessionInputAudioUnmuted;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveInputAudioUnmuted? value)
        {
            SessionInputAudioUnmuted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromSessionInputAudioUnmuted(global::tryAGI.OpenAI.LiveInputAudioUnmuted? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveInstructionsAppended value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveInstructionsAppended?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInstructionsAppended?(LiveServerEvent2 @this) => @this.SessionInstructionsAppended;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveInstructionsAppended? value)
        {
            SessionInstructionsAppended = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromSessionInstructionsAppended(global::tryAGI.OpenAI.LiveInstructionsAppended? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveThinkingAppended value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveThinkingAppended?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveThinkingAppended?(LiveServerEvent2 @this) => @this.SessionThinkingAppended;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveThinkingAppended? value)
        {
            SessionThinkingAppended = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromSessionThinkingAppended(global::tryAGI.OpenAI.LiveThinkingAppended? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveCommentaryAppended value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveCommentaryAppended?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveCommentaryAppended?(LiveServerEvent2 @this) => @this.SessionCommentaryAppended;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveCommentaryAppended? value)
        {
            SessionCommentaryAppended = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromSessionCommentaryAppended(global::tryAGI.OpenAI.LiveCommentaryAppended? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveInputAudioAppend value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveInputAudioAppend?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInputAudioAppend?(LiveServerEvent2 @this) => @this.SessionInputAudioAppend;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveInputAudioAppend? value)
        {
            SessionInputAudioAppend = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromSessionInputAudioAppend(global::tryAGI.OpenAI.LiveInputAudioAppend? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveOutputAudioDelta value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveOutputAudioDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveOutputAudioDelta?(LiveServerEvent2 @this) => @this.SessionOutputAudioDelta;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveOutputAudioDelta? value)
        {
            SessionOutputAudioDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromSessionOutputAudioDelta(global::tryAGI.OpenAI.LiveOutputAudioDelta? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveInputTranscriptDelta value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveInputTranscriptDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInputTranscriptDelta?(LiveServerEvent2 @this) => @this.SessionInputTranscriptDelta;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveInputTranscriptDelta? value)
        {
            SessionInputTranscriptDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromSessionInputTranscriptDelta(global::tryAGI.OpenAI.LiveInputTranscriptDelta? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveOutputTranscriptDelta value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveOutputTranscriptDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveOutputTranscriptDelta?(LiveServerEvent2 @this) => @this.SessionOutputTranscriptDelta;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveOutputTranscriptDelta? value)
        {
            SessionOutputTranscriptDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromSessionOutputTranscriptDelta(global::tryAGI.OpenAI.LiveOutputTranscriptDelta? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveDelegationCreated value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveDelegationCreated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveDelegationCreated?(LiveServerEvent2 @this) => @this.SessionDelegationCreated;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveDelegationCreated? value)
        {
            SessionDelegationCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromSessionDelegationCreated(global::tryAGI.OpenAI.LiveDelegationCreated? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveResponseEvent value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveResponseEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveResponseEvent?(LiveServerEvent2 @this) => @this.ResponseEvent;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveResponseEvent? value)
        {
            ResponseEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromResponseEvent(global::tryAGI.OpenAI.LiveResponseEvent? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveSessionUsageUpdated value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveSessionUsageUpdated?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionUsageUpdated?(LiveServerEvent2 @this) => @this.SessionUsageUpdated;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveSessionUsageUpdated? value)
        {
            SessionUsageUpdated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromSessionUsageUpdated(global::tryAGI.OpenAI.LiveSessionUsageUpdated? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveSessionClosed value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveSessionClosed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveSessionClosed?(LiveServerEvent2 @this) => @this.SessionClosed;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveSessionClosed? value)
        {
            SessionClosed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromSessionClosed(global::tryAGI.OpenAI.LiveSessionClosed? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveErrorEvent value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveErrorEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveErrorEvent?(LiveServerEvent2 @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromError(global::tryAGI.OpenAI.LiveErrorEvent? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveInfoEvent value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveInfoEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveInfoEvent?(LiveServerEvent2 @this) => @this.Info;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveInfoEvent? value)
        {
            Info = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromInfo(global::tryAGI.OpenAI.LiveInfoEvent? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveTransportDTMFReceived value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveTransportDTMFReceived?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveTransportDTMFReceived?(LiveServerEvent2 @this) => @this.TransportDtmfReceived;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveTransportDTMFReceived? value)
        {
            TransportDtmfReceived = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromTransportDtmfReceived(global::tryAGI.OpenAI.LiveTransportDTMFReceived? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveTransportDTMFSend value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveTransportDTMFSend?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveTransportDTMFSend?(LiveServerEvent2 @this) => @this.TransportDtmfSend;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveTransportDTMFSend? value)
        {
            TransportDtmfSend = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromTransportDtmfSend(global::tryAGI.OpenAI.LiveTransportDTMFSend? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveTransportRinging value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveTransportRinging?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveTransportRinging?(LiveServerEvent2 @this) => @this.TransportRinging;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveTransportRinging? value)
        {
            TransportRinging = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromTransportRinging(global::tryAGI.OpenAI.LiveTransportRinging? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveTransportAnswered value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveTransportAnswered?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveTransportAnswered?(LiveServerEvent2 @this) => @this.TransportAnswered;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveTransportAnswered? value)
        {
            TransportAnswered = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromTransportAnswered(global::tryAGI.OpenAI.LiveTransportAnswered? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LiveServerEvent2(global::tryAGI.OpenAI.LiveTransportFailed value) => new LiveServerEvent2((global::tryAGI.OpenAI.LiveTransportFailed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::tryAGI.OpenAI.LiveTransportFailed?(LiveServerEvent2 @this) => @this.TransportFailed;

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(global::tryAGI.OpenAI.LiveTransportFailed? value)
        {
            TransportFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LiveServerEvent2 FromTransportFailed(global::tryAGI.OpenAI.LiveTransportFailed? value) => new LiveServerEvent2(value);

        /// <summary>
        ///
        /// </summary>
        public LiveServerEvent2(
            global::tryAGI.OpenAI.LiveServerEvent2DiscriminatorType? type,
            global::tryAGI.OpenAI.LiveSessionStarted? sessionStarted,
            global::tryAGI.OpenAI.LiveSessionUpdated? sessionUpdated,
            global::tryAGI.OpenAI.LiveInputAudioMuted? sessionInputAudioMuted,
            global::tryAGI.OpenAI.LiveInputAudioUnmuted? sessionInputAudioUnmuted,
            global::tryAGI.OpenAI.LiveInstructionsAppended? sessionInstructionsAppended,
            global::tryAGI.OpenAI.LiveThinkingAppended? sessionThinkingAppended,
            global::tryAGI.OpenAI.LiveCommentaryAppended? sessionCommentaryAppended,
            global::tryAGI.OpenAI.LiveInputAudioAppend? sessionInputAudioAppend,
            global::tryAGI.OpenAI.LiveOutputAudioDelta? sessionOutputAudioDelta,
            global::tryAGI.OpenAI.LiveInputTranscriptDelta? sessionInputTranscriptDelta,
            global::tryAGI.OpenAI.LiveOutputTranscriptDelta? sessionOutputTranscriptDelta,
            global::tryAGI.OpenAI.LiveDelegationCreated? sessionDelegationCreated,
            global::tryAGI.OpenAI.LiveResponseEvent? responseEvent,
            global::tryAGI.OpenAI.LiveSessionUsageUpdated? sessionUsageUpdated,
            global::tryAGI.OpenAI.LiveSessionClosed? sessionClosed,
            global::tryAGI.OpenAI.LiveErrorEvent? error,
            global::tryAGI.OpenAI.LiveInfoEvent? info,
            global::tryAGI.OpenAI.LiveTransportDTMFReceived? transportDtmfReceived,
            global::tryAGI.OpenAI.LiveTransportDTMFSend? transportDtmfSend,
            global::tryAGI.OpenAI.LiveTransportRinging? transportRinging,
            global::tryAGI.OpenAI.LiveTransportAnswered? transportAnswered,
            global::tryAGI.OpenAI.LiveTransportFailed? transportFailed
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
            SessionInputAudioAppend = sessionInputAudioAppend;
            SessionOutputAudioDelta = sessionOutputAudioDelta;
            SessionInputTranscriptDelta = sessionInputTranscriptDelta;
            SessionOutputTranscriptDelta = sessionOutputTranscriptDelta;
            SessionDelegationCreated = sessionDelegationCreated;
            ResponseEvent = responseEvent;
            SessionUsageUpdated = sessionUsageUpdated;
            SessionClosed = sessionClosed;
            Error = error;
            Info = info;
            TransportDtmfReceived = transportDtmfReceived;
            TransportDtmfSend = transportDtmfSend;
            TransportRinging = transportRinging;
            TransportAnswered = transportAnswered;
            TransportFailed = transportFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TransportFailed as object ??
            TransportAnswered as object ??
            TransportRinging as object ??
            TransportDtmfSend as object ??
            TransportDtmfReceived as object ??
            Info as object ??
            Error as object ??
            SessionClosed as object ??
            SessionUsageUpdated as object ??
            ResponseEvent as object ??
            SessionDelegationCreated as object ??
            SessionOutputTranscriptDelta as object ??
            SessionInputTranscriptDelta as object ??
            SessionOutputAudioDelta as object ??
            SessionInputAudioAppend as object ??
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
            SessionInputAudioAppend?.ToString() ??
            SessionOutputAudioDelta?.ToString() ??
            SessionInputTranscriptDelta?.ToString() ??
            SessionOutputTranscriptDelta?.ToString() ??
            SessionDelegationCreated?.ToString() ??
            ResponseEvent?.ToString() ??
            SessionUsageUpdated?.ToString() ??
            SessionClosed?.ToString() ??
            Error?.ToString() ??
            Info?.ToString() ??
            TransportDtmfReceived?.ToString() ??
            TransportDtmfSend?.ToString() ??
            TransportRinging?.ToString() ??
            TransportAnswered?.ToString() ??
            TransportFailed?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && IsTransportRinging && !IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && IsTransportAnswered && !IsTransportFailed || !IsSessionStarted && !IsSessionUpdated && !IsSessionInputAudioMuted && !IsSessionInputAudioUnmuted && !IsSessionInstructionsAppended && !IsSessionThinkingAppended && !IsSessionCommentaryAppended && !IsSessionInputAudioAppend && !IsSessionOutputAudioDelta && !IsSessionInputTranscriptDelta && !IsSessionOutputTranscriptDelta && !IsSessionDelegationCreated && !IsResponseEvent && !IsSessionUsageUpdated && !IsSessionClosed && !IsError && !IsInfo && !IsTransportDtmfReceived && !IsTransportDtmfSend && !IsTransportRinging && !IsTransportAnswered && IsTransportFailed;
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
            global::System.Func<global::tryAGI.OpenAI.LiveInputAudioAppend, TResult>? sessionInputAudioAppend = null,
            global::System.Func<global::tryAGI.OpenAI.LiveOutputAudioDelta, TResult>? sessionOutputAudioDelta = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInputTranscriptDelta, TResult>? sessionInputTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.LiveOutputTranscriptDelta, TResult>? sessionOutputTranscriptDelta = null,
            global::System.Func<global::tryAGI.OpenAI.LiveDelegationCreated, TResult>? sessionDelegationCreated = null,
            global::System.Func<global::tryAGI.OpenAI.LiveResponseEvent, TResult>? responseEvent = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSessionUsageUpdated, TResult>? sessionUsageUpdated = null,
            global::System.Func<global::tryAGI.OpenAI.LiveSessionClosed, TResult>? sessionClosed = null,
            global::System.Func<global::tryAGI.OpenAI.LiveErrorEvent, TResult>? error = null,
            global::System.Func<global::tryAGI.OpenAI.LiveInfoEvent, TResult>? info = null,
            global::System.Func<global::tryAGI.OpenAI.LiveTransportDTMFReceived, TResult>? transportDtmfReceived = null,
            global::System.Func<global::tryAGI.OpenAI.LiveTransportDTMFSend, TResult>? transportDtmfSend = null,
            global::System.Func<global::tryAGI.OpenAI.LiveTransportRinging, TResult>? transportRinging = null,
            global::System.Func<global::tryAGI.OpenAI.LiveTransportAnswered, TResult>? transportAnswered = null,
            global::System.Func<global::tryAGI.OpenAI.LiveTransportFailed, TResult>? transportFailed = null,
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
            else if (IsSessionInputAudioAppend && sessionInputAudioAppend != null)
            {
                return sessionInputAudioAppend(SessionInputAudioAppend!);
            }
            else if (IsSessionOutputAudioDelta && sessionOutputAudioDelta != null)
            {
                return sessionOutputAudioDelta(SessionOutputAudioDelta!);
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
            else if (IsTransportDtmfReceived && transportDtmfReceived != null)
            {
                return transportDtmfReceived(TransportDtmfReceived!);
            }
            else if (IsTransportDtmfSend && transportDtmfSend != null)
            {
                return transportDtmfSend(TransportDtmfSend!);
            }
            else if (IsTransportRinging && transportRinging != null)
            {
                return transportRinging(TransportRinging!);
            }
            else if (IsTransportAnswered && transportAnswered != null)
            {
                return transportAnswered(TransportAnswered!);
            }
            else if (IsTransportFailed && transportFailed != null)
            {
                return transportFailed(TransportFailed!);
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

            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioAppend>? sessionInputAudioAppend = null,

            global::System.Action<global::tryAGI.OpenAI.LiveOutputAudioDelta>? sessionOutputAudioDelta = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInputTranscriptDelta>? sessionInputTranscriptDelta = null,

            global::System.Action<global::tryAGI.OpenAI.LiveOutputTranscriptDelta>? sessionOutputTranscriptDelta = null,

            global::System.Action<global::tryAGI.OpenAI.LiveDelegationCreated>? sessionDelegationCreated = null,

            global::System.Action<global::tryAGI.OpenAI.LiveResponseEvent>? responseEvent = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSessionUsageUpdated>? sessionUsageUpdated = null,

            global::System.Action<global::tryAGI.OpenAI.LiveSessionClosed>? sessionClosed = null,

            global::System.Action<global::tryAGI.OpenAI.LiveErrorEvent>? error = null,

            global::System.Action<global::tryAGI.OpenAI.LiveInfoEvent>? info = null,

            global::System.Action<global::tryAGI.OpenAI.LiveTransportDTMFReceived>? transportDtmfReceived = null,

            global::System.Action<global::tryAGI.OpenAI.LiveTransportDTMFSend>? transportDtmfSend = null,

            global::System.Action<global::tryAGI.OpenAI.LiveTransportRinging>? transportRinging = null,

            global::System.Action<global::tryAGI.OpenAI.LiveTransportAnswered>? transportAnswered = null,

            global::System.Action<global::tryAGI.OpenAI.LiveTransportFailed>? transportFailed = null,
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
            else if (IsSessionInputAudioAppend)
            {
                sessionInputAudioAppend?.Invoke(SessionInputAudioAppend!);
            }
            else if (IsSessionOutputAudioDelta)
            {
                sessionOutputAudioDelta?.Invoke(SessionOutputAudioDelta!);
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
            else if (IsTransportDtmfReceived)
            {
                transportDtmfReceived?.Invoke(TransportDtmfReceived!);
            }
            else if (IsTransportDtmfSend)
            {
                transportDtmfSend?.Invoke(TransportDtmfSend!);
            }
            else if (IsTransportRinging)
            {
                transportRinging?.Invoke(TransportRinging!);
            }
            else if (IsTransportAnswered)
            {
                transportAnswered?.Invoke(TransportAnswered!);
            }
            else if (IsTransportFailed)
            {
                transportFailed?.Invoke(TransportFailed!);
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
            global::System.Action<global::tryAGI.OpenAI.LiveInputAudioAppend>? sessionInputAudioAppend = null,
            global::System.Action<global::tryAGI.OpenAI.LiveOutputAudioDelta>? sessionOutputAudioDelta = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInputTranscriptDelta>? sessionInputTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.LiveOutputTranscriptDelta>? sessionOutputTranscriptDelta = null,
            global::System.Action<global::tryAGI.OpenAI.LiveDelegationCreated>? sessionDelegationCreated = null,
            global::System.Action<global::tryAGI.OpenAI.LiveResponseEvent>? responseEvent = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSessionUsageUpdated>? sessionUsageUpdated = null,
            global::System.Action<global::tryAGI.OpenAI.LiveSessionClosed>? sessionClosed = null,
            global::System.Action<global::tryAGI.OpenAI.LiveErrorEvent>? error = null,
            global::System.Action<global::tryAGI.OpenAI.LiveInfoEvent>? info = null,
            global::System.Action<global::tryAGI.OpenAI.LiveTransportDTMFReceived>? transportDtmfReceived = null,
            global::System.Action<global::tryAGI.OpenAI.LiveTransportDTMFSend>? transportDtmfSend = null,
            global::System.Action<global::tryAGI.OpenAI.LiveTransportRinging>? transportRinging = null,
            global::System.Action<global::tryAGI.OpenAI.LiveTransportAnswered>? transportAnswered = null,
            global::System.Action<global::tryAGI.OpenAI.LiveTransportFailed>? transportFailed = null,
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
            else if (IsSessionInputAudioAppend)
            {
                sessionInputAudioAppend?.Invoke(SessionInputAudioAppend!);
            }
            else if (IsSessionOutputAudioDelta)
            {
                sessionOutputAudioDelta?.Invoke(SessionOutputAudioDelta!);
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
            else if (IsTransportDtmfReceived)
            {
                transportDtmfReceived?.Invoke(TransportDtmfReceived!);
            }
            else if (IsTransportDtmfSend)
            {
                transportDtmfSend?.Invoke(TransportDtmfSend!);
            }
            else if (IsTransportRinging)
            {
                transportRinging?.Invoke(TransportRinging!);
            }
            else if (IsTransportAnswered)
            {
                transportAnswered?.Invoke(TransportAnswered!);
            }
            else if (IsTransportFailed)
            {
                transportFailed?.Invoke(TransportFailed!);
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
                SessionInputAudioAppend,
                typeof(global::tryAGI.OpenAI.LiveInputAudioAppend),
                SessionOutputAudioDelta,
                typeof(global::tryAGI.OpenAI.LiveOutputAudioDelta),
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
                TransportDtmfReceived,
                typeof(global::tryAGI.OpenAI.LiveTransportDTMFReceived),
                TransportDtmfSend,
                typeof(global::tryAGI.OpenAI.LiveTransportDTMFSend),
                TransportRinging,
                typeof(global::tryAGI.OpenAI.LiveTransportRinging),
                TransportAnswered,
                typeof(global::tryAGI.OpenAI.LiveTransportAnswered),
                TransportFailed,
                typeof(global::tryAGI.OpenAI.LiveTransportFailed),
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
        public bool Equals(LiveServerEvent2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionStarted?>.Default.Equals(SessionStarted, other.SessionStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionUpdated?>.Default.Equals(SessionUpdated, other.SessionUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInputAudioMuted?>.Default.Equals(SessionInputAudioMuted, other.SessionInputAudioMuted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInputAudioUnmuted?>.Default.Equals(SessionInputAudioUnmuted, other.SessionInputAudioUnmuted) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInstructionsAppended?>.Default.Equals(SessionInstructionsAppended, other.SessionInstructionsAppended) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveThinkingAppended?>.Default.Equals(SessionThinkingAppended, other.SessionThinkingAppended) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveCommentaryAppended?>.Default.Equals(SessionCommentaryAppended, other.SessionCommentaryAppended) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInputAudioAppend?>.Default.Equals(SessionInputAudioAppend, other.SessionInputAudioAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveOutputAudioDelta?>.Default.Equals(SessionOutputAudioDelta, other.SessionOutputAudioDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInputTranscriptDelta?>.Default.Equals(SessionInputTranscriptDelta, other.SessionInputTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveOutputTranscriptDelta?>.Default.Equals(SessionOutputTranscriptDelta, other.SessionOutputTranscriptDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveDelegationCreated?>.Default.Equals(SessionDelegationCreated, other.SessionDelegationCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveResponseEvent?>.Default.Equals(ResponseEvent, other.ResponseEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionUsageUpdated?>.Default.Equals(SessionUsageUpdated, other.SessionUsageUpdated) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveSessionClosed?>.Default.Equals(SessionClosed, other.SessionClosed) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveErrorEvent?>.Default.Equals(Error, other.Error) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveInfoEvent?>.Default.Equals(Info, other.Info) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveTransportDTMFReceived?>.Default.Equals(TransportDtmfReceived, other.TransportDtmfReceived) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveTransportDTMFSend?>.Default.Equals(TransportDtmfSend, other.TransportDtmfSend) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveTransportRinging?>.Default.Equals(TransportRinging, other.TransportRinging) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveTransportAnswered?>.Default.Equals(TransportAnswered, other.TransportAnswered) &&
                global::System.Collections.Generic.EqualityComparer<global::tryAGI.OpenAI.LiveTransportFailed?>.Default.Equals(TransportFailed, other.TransportFailed)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LiveServerEvent2 obj1, LiveServerEvent2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LiveServerEvent2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LiveServerEvent2 obj1, LiveServerEvent2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LiveServerEvent2 o && Equals(o);
        }
    }
}
