
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveSidebandServerEventDiscriminatorType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSidebandServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSidebandServerEventDiscriminatorType value)
        {
            return value switch
            {
                LiveSidebandServerEventDiscriminatorType.Error => "error",
                LiveSidebandServerEventDiscriminatorType.Info => "info",
                LiveSidebandServerEventDiscriminatorType.ResponseEvent => "response.event",
                LiveSidebandServerEventDiscriminatorType.SessionClosed => "session.closed",
                LiveSidebandServerEventDiscriminatorType.SessionCommentaryAppended => "session.commentary.appended",
                LiveSidebandServerEventDiscriminatorType.SessionDelegationCreated => "session.delegation.created",
                LiveSidebandServerEventDiscriminatorType.SessionInputAudioMuted => "session.input_audio.muted",
                LiveSidebandServerEventDiscriminatorType.SessionInputAudioUnmuted => "session.input_audio.unmuted",
                LiveSidebandServerEventDiscriminatorType.SessionInputTranscriptDelta => "session.input_transcript.delta",
                LiveSidebandServerEventDiscriminatorType.SessionInstructionsAppended => "session.instructions.appended",
                LiveSidebandServerEventDiscriminatorType.SessionOutputTranscriptDelta => "session.output_transcript.delta",
                LiveSidebandServerEventDiscriminatorType.SessionStarted => "session.started",
                LiveSidebandServerEventDiscriminatorType.SessionThinkingAppended => "session.thinking.appended",
                LiveSidebandServerEventDiscriminatorType.SessionUpdated => "session.updated",
                LiveSidebandServerEventDiscriminatorType.SessionUsageUpdated => "session.usage.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSidebandServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => LiveSidebandServerEventDiscriminatorType.Error,
                "info" => LiveSidebandServerEventDiscriminatorType.Info,
                "response.event" => LiveSidebandServerEventDiscriminatorType.ResponseEvent,
                "session.closed" => LiveSidebandServerEventDiscriminatorType.SessionClosed,
                "session.commentary.appended" => LiveSidebandServerEventDiscriminatorType.SessionCommentaryAppended,
                "session.delegation.created" => LiveSidebandServerEventDiscriminatorType.SessionDelegationCreated,
                "session.input_audio.muted" => LiveSidebandServerEventDiscriminatorType.SessionInputAudioMuted,
                "session.input_audio.unmuted" => LiveSidebandServerEventDiscriminatorType.SessionInputAudioUnmuted,
                "session.input_transcript.delta" => LiveSidebandServerEventDiscriminatorType.SessionInputTranscriptDelta,
                "session.instructions.appended" => LiveSidebandServerEventDiscriminatorType.SessionInstructionsAppended,
                "session.output_transcript.delta" => LiveSidebandServerEventDiscriminatorType.SessionOutputTranscriptDelta,
                "session.started" => LiveSidebandServerEventDiscriminatorType.SessionStarted,
                "session.thinking.appended" => LiveSidebandServerEventDiscriminatorType.SessionThinkingAppended,
                "session.updated" => LiveSidebandServerEventDiscriminatorType.SessionUpdated,
                "session.usage.updated" => LiveSidebandServerEventDiscriminatorType.SessionUsageUpdated,
                _ => null,
            };
        }
    }
}