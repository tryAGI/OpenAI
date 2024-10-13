
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "input_audio_buffer.committed".<br/>
    /// Example: input_audio_buffer.committed
    /// </summary>
    public enum RealtimeInputAudioBufferCommittedType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCommitted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeInputAudioBufferCommittedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeInputAudioBufferCommittedType value)
        {
            return value switch
            {
                RealtimeInputAudioBufferCommittedType.InputAudioBufferCommitted => "input_audio_buffer.committed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeInputAudioBufferCommittedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.committed" => RealtimeInputAudioBufferCommittedType.InputAudioBufferCommitted,
                _ => null,
            };
        }
    }
}