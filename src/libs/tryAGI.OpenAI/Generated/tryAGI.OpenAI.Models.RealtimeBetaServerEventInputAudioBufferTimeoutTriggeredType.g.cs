
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.timeout_triggered`.
    /// </summary>
    public enum RealtimeBetaServerEventInputAudioBufferTimeoutTriggeredType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferTimeoutTriggered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventInputAudioBufferTimeoutTriggeredTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventInputAudioBufferTimeoutTriggeredType value)
        {
            return value switch
            {
                RealtimeBetaServerEventInputAudioBufferTimeoutTriggeredType.InputAudioBufferTimeoutTriggered => "input_audio_buffer.timeout_triggered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventInputAudioBufferTimeoutTriggeredType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.timeout_triggered" => RealtimeBetaServerEventInputAudioBufferTimeoutTriggeredType.InputAudioBufferTimeoutTriggered,
                _ => null,
            };
        }
    }
}