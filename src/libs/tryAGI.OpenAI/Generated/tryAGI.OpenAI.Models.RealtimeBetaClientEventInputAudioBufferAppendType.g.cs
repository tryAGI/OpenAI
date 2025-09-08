
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.append`.
    /// </summary>
    public enum RealtimeBetaClientEventInputAudioBufferAppendType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaClientEventInputAudioBufferAppendTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaClientEventInputAudioBufferAppendType value)
        {
            return value switch
            {
                RealtimeBetaClientEventInputAudioBufferAppendType.InputAudioBufferAppend => "input_audio_buffer.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaClientEventInputAudioBufferAppendType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.append" => RealtimeBetaClientEventInputAudioBufferAppendType.InputAudioBufferAppend,
                _ => null,
            };
        }
    }
}