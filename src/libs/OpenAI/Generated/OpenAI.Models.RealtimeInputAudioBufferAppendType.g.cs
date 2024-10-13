
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "input_audio_buffer.append".<br/>
    /// Example: input_audio_buffer.append
    /// </summary>
    public enum RealtimeInputAudioBufferAppendType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeInputAudioBufferAppendTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeInputAudioBufferAppendType value)
        {
            return value switch
            {
                RealtimeInputAudioBufferAppendType.InputAudioBufferAppend => "input_audio_buffer.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeInputAudioBufferAppendType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.append" => RealtimeInputAudioBufferAppendType.InputAudioBufferAppend,
                _ => null,
            };
        }
    }
}