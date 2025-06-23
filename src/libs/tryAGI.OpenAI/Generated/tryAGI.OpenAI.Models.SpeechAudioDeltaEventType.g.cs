
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `speech.audio.delta`.
    /// </summary>
    public enum SpeechAudioDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechAudioDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechAudioDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechAudioDeltaEventType value)
        {
            return value switch
            {
                SpeechAudioDeltaEventType.SpeechAudioDelta => "speech.audio.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechAudioDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "speech.audio.delta" => SpeechAudioDeltaEventType.SpeechAudioDelta,
                _ => null,
            };
        }
    }
}