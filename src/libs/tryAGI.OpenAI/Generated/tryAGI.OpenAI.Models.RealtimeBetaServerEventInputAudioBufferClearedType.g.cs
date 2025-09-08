
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.cleared`.
    /// </summary>
    public enum RealtimeBetaServerEventInputAudioBufferClearedType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferCleared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventInputAudioBufferClearedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventInputAudioBufferClearedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventInputAudioBufferClearedType.InputAudioBufferCleared => "input_audio_buffer.cleared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventInputAudioBufferClearedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.cleared" => RealtimeBetaServerEventInputAudioBufferClearedType.InputAudioBufferCleared,
                _ => null,
            };
        }
    }
}