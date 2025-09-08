
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.commit`.
    /// </summary>
    public enum RealtimeBetaClientEventInputAudioBufferCommitType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCommit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaClientEventInputAudioBufferCommitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaClientEventInputAudioBufferCommitType value)
        {
            return value switch
            {
                RealtimeBetaClientEventInputAudioBufferCommitType.InputAudioBufferCommit => "input_audio_buffer.commit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaClientEventInputAudioBufferCommitType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.commit" => RealtimeBetaClientEventInputAudioBufferCommitType.InputAudioBufferCommit,
                _ => null,
            };
        }
    }
}