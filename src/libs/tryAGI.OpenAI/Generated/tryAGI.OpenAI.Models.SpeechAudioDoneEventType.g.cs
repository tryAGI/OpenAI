
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `speech.audio.done`.
    /// </summary>
    public enum SpeechAudioDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        SpeechAudioDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechAudioDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechAudioDoneEventType value)
        {
            return value switch
            {
                SpeechAudioDoneEventType.SpeechAudioDone => "speech.audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechAudioDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "speech.audio.done" => SpeechAudioDoneEventType.SpeechAudioDone,
                _ => null,
            };
        }
    }
}