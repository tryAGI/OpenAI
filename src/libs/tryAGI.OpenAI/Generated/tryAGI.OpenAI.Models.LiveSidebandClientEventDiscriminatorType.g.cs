
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveSidebandClientEventDiscriminatorType
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
        SessionThinkingAppend,
        /// <summary>
        ///
        /// </summary>
        SessionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSidebandClientEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSidebandClientEventDiscriminatorType value)
        {
            return value switch
            {
                LiveSidebandClientEventDiscriminatorType.ResponseCreate => "response.create",
                LiveSidebandClientEventDiscriminatorType.ResponseItemCreate => "response.item.create",
                LiveSidebandClientEventDiscriminatorType.SessionClose => "session.close",
                LiveSidebandClientEventDiscriminatorType.SessionCommentaryAppend => "session.commentary.append",
                LiveSidebandClientEventDiscriminatorType.SessionInputAudioMute => "session.input_audio.mute",
                LiveSidebandClientEventDiscriminatorType.SessionInputAudioUnmute => "session.input_audio.unmute",
                LiveSidebandClientEventDiscriminatorType.SessionInstructionsAppend => "session.instructions.append",
                LiveSidebandClientEventDiscriminatorType.SessionThinkingAppend => "session.thinking.append",
                LiveSidebandClientEventDiscriminatorType.SessionUpdate => "session.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSidebandClientEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "response.create" => LiveSidebandClientEventDiscriminatorType.ResponseCreate,
                "response.item.create" => LiveSidebandClientEventDiscriminatorType.ResponseItemCreate,
                "session.close" => LiveSidebandClientEventDiscriminatorType.SessionClose,
                "session.commentary.append" => LiveSidebandClientEventDiscriminatorType.SessionCommentaryAppend,
                "session.input_audio.mute" => LiveSidebandClientEventDiscriminatorType.SessionInputAudioMute,
                "session.input_audio.unmute" => LiveSidebandClientEventDiscriminatorType.SessionInputAudioUnmute,
                "session.instructions.append" => LiveSidebandClientEventDiscriminatorType.SessionInstructionsAppend,
                "session.thinking.append" => LiveSidebandClientEventDiscriminatorType.SessionThinkingAppend,
                "session.update" => LiveSidebandClientEventDiscriminatorType.SessionUpdate,
                _ => null,
            };
        }
    }
}