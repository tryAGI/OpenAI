
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveForkClientEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCreate,
        /// <summary>
        ///
        /// </summary>
        ResponseItemCreate,
        /// <summary>
        ///
        /// </summary>
        SessionClose,
        /// <summary>
        ///
        /// </summary>
        SessionCommentaryAppend,
        /// <summary>
        ///
        /// </summary>
        SessionInputAudioAppend,
        /// <summary>
        ///
        /// </summary>
        SessionInputAudioMute,
        /// <summary>
        ///
        /// </summary>
        SessionInputAudioUnmute,
        /// <summary>
        ///
        /// </summary>
        SessionInstructionsAppend,
        /// <summary>
        ///
        /// </summary>
        SessionStart,
        /// <summary>
        ///
        /// </summary>
        SessionThinkingAppend,
        /// <summary>
        ///
        /// </summary>
        SessionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveForkClientEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveForkClientEventDiscriminatorType value)
        {
            return value switch
            {
                LiveForkClientEventDiscriminatorType.ResponseCreate => "response.create",
                LiveForkClientEventDiscriminatorType.ResponseItemCreate => "response.item.create",
                LiveForkClientEventDiscriminatorType.SessionClose => "session.close",
                LiveForkClientEventDiscriminatorType.SessionCommentaryAppend => "session.commentary.append",
                LiveForkClientEventDiscriminatorType.SessionInputAudioAppend => "session.input_audio.append",
                LiveForkClientEventDiscriminatorType.SessionInputAudioMute => "session.input_audio.mute",
                LiveForkClientEventDiscriminatorType.SessionInputAudioUnmute => "session.input_audio.unmute",
                LiveForkClientEventDiscriminatorType.SessionInstructionsAppend => "session.instructions.append",
                LiveForkClientEventDiscriminatorType.SessionStart => "session.start",
                LiveForkClientEventDiscriminatorType.SessionThinkingAppend => "session.thinking.append",
                LiveForkClientEventDiscriminatorType.SessionUpdate => "session.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveForkClientEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "response.create" => LiveForkClientEventDiscriminatorType.ResponseCreate,
                "response.item.create" => LiveForkClientEventDiscriminatorType.ResponseItemCreate,
                "session.close" => LiveForkClientEventDiscriminatorType.SessionClose,
                "session.commentary.append" => LiveForkClientEventDiscriminatorType.SessionCommentaryAppend,
                "session.input_audio.append" => LiveForkClientEventDiscriminatorType.SessionInputAudioAppend,
                "session.input_audio.mute" => LiveForkClientEventDiscriminatorType.SessionInputAudioMute,
                "session.input_audio.unmute" => LiveForkClientEventDiscriminatorType.SessionInputAudioUnmute,
                "session.instructions.append" => LiveForkClientEventDiscriminatorType.SessionInstructionsAppend,
                "session.start" => LiveForkClientEventDiscriminatorType.SessionStart,
                "session.thinking.append" => LiveForkClientEventDiscriminatorType.SessionThinkingAppend,
                "session.update" => LiveForkClientEventDiscriminatorType.SessionUpdate,
                _ => null,
            };
        }
    }
}