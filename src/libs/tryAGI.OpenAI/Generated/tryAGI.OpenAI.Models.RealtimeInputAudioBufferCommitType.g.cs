
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be "input_audio_buffer.commit".<br/>
    /// Example: input_audio_buffer.commit
    /// </summary>
    public enum RealtimeInputAudioBufferCommitType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCommit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeInputAudioBufferCommitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeInputAudioBufferCommitType value)
        {
            return value switch
            {
                RealtimeInputAudioBufferCommitType.InputAudioBufferCommit => "input_audio_buffer.commit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeInputAudioBufferCommitType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.commit" => RealtimeInputAudioBufferCommitType.InputAudioBufferCommit,
                _ => null,
            };
        }
    }
}