
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveClientEventDiscriminatorType
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
    public static class LiveClientEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveClientEventDiscriminatorType value)
        {
            return value switch
            {
                LiveClientEventDiscriminatorType.ResponseCreate => "response.create",
                LiveClientEventDiscriminatorType.ResponseItemCreate => "response.item.create",
                LiveClientEventDiscriminatorType.SessionClose => "session.close",
                LiveClientEventDiscriminatorType.SessionCommentaryAppend => "session.commentary.append",
                LiveClientEventDiscriminatorType.SessionInputAudioAppend => "session.input_audio.append",
                LiveClientEventDiscriminatorType.SessionInputAudioMute => "session.input_audio.mute",
                LiveClientEventDiscriminatorType.SessionInputAudioUnmute => "session.input_audio.unmute",
                LiveClientEventDiscriminatorType.SessionInstructionsAppend => "session.instructions.append",
                LiveClientEventDiscriminatorType.SessionStart => "session.start",
                LiveClientEventDiscriminatorType.SessionThinkingAppend => "session.thinking.append",
                LiveClientEventDiscriminatorType.SessionUpdate => "session.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveClientEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "response.create" => LiveClientEventDiscriminatorType.ResponseCreate,
                "response.item.create" => LiveClientEventDiscriminatorType.ResponseItemCreate,
                "session.close" => LiveClientEventDiscriminatorType.SessionClose,
                "session.commentary.append" => LiveClientEventDiscriminatorType.SessionCommentaryAppend,
                "session.input_audio.append" => LiveClientEventDiscriminatorType.SessionInputAudioAppend,
                "session.input_audio.mute" => LiveClientEventDiscriminatorType.SessionInputAudioMute,
                "session.input_audio.unmute" => LiveClientEventDiscriminatorType.SessionInputAudioUnmute,
                "session.instructions.append" => LiveClientEventDiscriminatorType.SessionInstructionsAppend,
                "session.start" => LiveClientEventDiscriminatorType.SessionStart,
                "session.thinking.append" => LiveClientEventDiscriminatorType.SessionThinkingAppend,
                "session.update" => LiveClientEventDiscriminatorType.SessionUpdate,
                _ => null,
            };
        }
    }
}