
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "input_audio_buffer.clear".<br/>
    /// Example: input_audio_buffer.clear
    /// </summary>
    public enum RealtimeInputAudioBufferClearType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferClear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeInputAudioBufferClearTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeInputAudioBufferClearType value)
        {
            return value switch
            {
                RealtimeInputAudioBufferClearType.InputAudioBufferClear => "input_audio_buffer.clear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeInputAudioBufferClearType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.clear" => RealtimeInputAudioBufferClearType.InputAudioBufferClear,
                _ => null,
            };
        }
    }
}