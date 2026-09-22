
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveServerEvent2DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Info,
        /// <summary>
        ///
        /// </summary>
        ResponseEvent,
        /// <summary>
        ///
        /// </summary>
        SessionClosed,
        /// <summary>
        ///
        /// </summary>
        SessionCommentaryAppended,
        /// <summary>
        ///
        /// </summary>
        SessionDelegationCreated,
        /// <summary>
        ///
        /// </summary>
        SessionInputAudioAppend,
        /// <summary>
        ///
        /// </summary>
        SessionInputAudioMuted,
        /// <summary>
        ///
        /// </summary>
        SessionInputAudioUnmuted,
        /// <summary>
        ///
        /// </summary>
        SessionInputTranscriptDelta,
        /// <summary>
        ///
        /// </summary>
        SessionInstructionsAppended,
        /// <summary>
        ///
        /// </summary>
        SessionOutputAudioDelta,
        /// <summary>
        ///
        /// </summary>
        SessionOutputTranscriptDelta,
        /// <summary>
        ///
        /// </summary>
        SessionStarted,
        /// <summary>
        ///
        /// </summary>
        SessionThinkingAppended,
        /// <summary>
        ///
        /// </summary>
        SessionUpdated,
        /// <summary>
        ///
        /// </summary>
        SessionUsageUpdated,
        /// <summary>
        ///
        /// </summary>
        TransportAnswered,
        /// <summary>
        ///
        /// </summary>
        TransportDtmfReceived,
        /// <summary>
        ///
        /// </summary>
        TransportDtmfSend,
        /// <summary>
        ///
        /// </summary>
        TransportFailed,
        /// <summary>
        ///
        /// </summary>
        TransportRinging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveServerEvent2DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveServerEvent2DiscriminatorType value)
        {
            return value switch
            {
                LiveServerEvent2DiscriminatorType.Error => "error",
                LiveServerEvent2DiscriminatorType.Info => "info",
                LiveServerEvent2DiscriminatorType.ResponseEvent => "response.event",
                LiveServerEvent2DiscriminatorType.SessionClosed => "session.closed",
                LiveServerEvent2DiscriminatorType.SessionCommentaryAppended => "session.commentary.appended",
                LiveServerEvent2DiscriminatorType.SessionDelegationCreated => "session.delegation.created",
                LiveServerEvent2DiscriminatorType.SessionInputAudioAppend => "session.input_audio.append",
                LiveServerEvent2DiscriminatorType.SessionInputAudioMuted => "session.input_audio.muted",
                LiveServerEvent2DiscriminatorType.SessionInputAudioUnmuted => "session.input_audio.unmuted",
                LiveServerEvent2DiscriminatorType.SessionInputTranscriptDelta => "session.input_transcript.delta",
                LiveServerEvent2DiscriminatorType.SessionInstructionsAppended => "session.instructions.appended",
                LiveServerEvent2DiscriminatorType.SessionOutputAudioDelta => "session.output_audio.delta",
                LiveServerEvent2DiscriminatorType.SessionOutputTranscriptDelta => "session.output_transcript.delta",
                LiveServerEvent2DiscriminatorType.SessionStarted => "session.started",
                LiveServerEvent2DiscriminatorType.SessionThinkingAppended => "session.thinking.appended",
                LiveServerEvent2DiscriminatorType.SessionUpdated => "session.updated",
                LiveServerEvent2DiscriminatorType.SessionUsageUpdated => "session.usage.updated",
                LiveServerEvent2DiscriminatorType.TransportAnswered => "transport.answered",
                LiveServerEvent2DiscriminatorType.TransportDtmfReceived => "transport.dtmf.received",
                LiveServerEvent2DiscriminatorType.TransportDtmfSend => "transport.dtmf.send",
                LiveServerEvent2DiscriminatorType.TransportFailed => "transport.failed",
                LiveServerEvent2DiscriminatorType.TransportRinging => "transport.ringing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveServerEvent2DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => LiveServerEvent2DiscriminatorType.Error,
                "info" => LiveServerEvent2DiscriminatorType.Info,
                "response.event" => LiveServerEvent2DiscriminatorType.ResponseEvent,
                "session.closed" => LiveServerEvent2DiscriminatorType.SessionClosed,
                "session.commentary.appended" => LiveServerEvent2DiscriminatorType.SessionCommentaryAppended,
                "session.delegation.created" => LiveServerEvent2DiscriminatorType.SessionDelegationCreated,
                "session.input_audio.append" => LiveServerEvent2DiscriminatorType.SessionInputAudioAppend,
                "session.input_audio.muted" => LiveServerEvent2DiscriminatorType.SessionInputAudioMuted,
                "session.input_audio.unmuted" => LiveServerEvent2DiscriminatorType.SessionInputAudioUnmuted,
                "session.input_transcript.delta" => LiveServerEvent2DiscriminatorType.SessionInputTranscriptDelta,
                "session.instructions.appended" => LiveServerEvent2DiscriminatorType.SessionInstructionsAppended,
                "session.output_audio.delta" => LiveServerEvent2DiscriminatorType.SessionOutputAudioDelta,
                "session.output_transcript.delta" => LiveServerEvent2DiscriminatorType.SessionOutputTranscriptDelta,
                "session.started" => LiveServerEvent2DiscriminatorType.SessionStarted,
                "session.thinking.appended" => LiveServerEvent2DiscriminatorType.SessionThinkingAppended,
                "session.updated" => LiveServerEvent2DiscriminatorType.SessionUpdated,
                "session.usage.updated" => LiveServerEvent2DiscriminatorType.SessionUsageUpdated,
                "transport.answered" => LiveServerEvent2DiscriminatorType.TransportAnswered,
                "transport.dtmf.received" => LiveServerEvent2DiscriminatorType.TransportDtmfReceived,
                "transport.dtmf.send" => LiveServerEvent2DiscriminatorType.TransportDtmfSend,
                "transport.failed" => LiveServerEvent2DiscriminatorType.TransportFailed,
                "transport.ringing" => LiveServerEvent2DiscriminatorType.TransportRinging,
                _ => null,
            };
        }
    }
}