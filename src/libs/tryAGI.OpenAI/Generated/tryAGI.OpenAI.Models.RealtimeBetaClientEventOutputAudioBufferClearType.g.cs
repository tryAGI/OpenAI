
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `output_audio_buffer.clear`.
    /// </summary>
    public enum RealtimeBetaClientEventOutputAudioBufferClearType
    {
        /// <summary>
        /// 
        /// </summary>
        OutputAudioBufferClear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaClientEventOutputAudioBufferClearTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaClientEventOutputAudioBufferClearType value)
        {
            return value switch
            {
                RealtimeBetaClientEventOutputAudioBufferClearType.OutputAudioBufferClear => "output_audio_buffer.clear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaClientEventOutputAudioBufferClearType? ToEnum(string value)
        {
            return value switch
            {
                "output_audio_buffer.clear" => RealtimeBetaClientEventOutputAudioBufferClearType.OutputAudioBufferClear,
                _ => null,
            };
        }
    }
}