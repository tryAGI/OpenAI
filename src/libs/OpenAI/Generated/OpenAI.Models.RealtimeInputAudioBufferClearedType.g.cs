
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "input_audio_buffer.cleared".<br/>
    /// Example: input_audio_buffer.cleared
    /// </summary>
    public enum RealtimeInputAudioBufferClearedType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCleared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeInputAudioBufferClearedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeInputAudioBufferClearedType value)
        {
            return value switch
            {
                RealtimeInputAudioBufferClearedType.InputAudioBufferCleared => "input_audio_buffer.cleared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeInputAudioBufferClearedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.cleared" => RealtimeInputAudioBufferClearedType.InputAudioBufferCleared,
                _ => null,
            };
        }
    }
}