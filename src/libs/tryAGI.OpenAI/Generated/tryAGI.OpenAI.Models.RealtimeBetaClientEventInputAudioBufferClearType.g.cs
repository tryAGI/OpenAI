
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.clear`.
    /// </summary>
    public enum RealtimeBetaClientEventInputAudioBufferClearType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferClear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaClientEventInputAudioBufferClearTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaClientEventInputAudioBufferClearType value)
        {
            return value switch
            {
                RealtimeBetaClientEventInputAudioBufferClearType.InputAudioBufferClear => "input_audio_buffer.clear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaClientEventInputAudioBufferClearType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.clear" => RealtimeBetaClientEventInputAudioBufferClearType.InputAudioBufferClear,
                _ => null,
            };
        }
    }
}