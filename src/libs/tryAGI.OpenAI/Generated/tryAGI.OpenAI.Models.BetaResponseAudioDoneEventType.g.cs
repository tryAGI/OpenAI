
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.audio.done`.
    /// </summary>
    public enum BetaResponseAudioDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseAudioDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseAudioDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseAudioDoneEventType value)
        {
            return value switch
            {
                BetaResponseAudioDoneEventType.ResponseAudioDone => "response.audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseAudioDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.audio.done" => BetaResponseAudioDoneEventType.ResponseAudioDone,
                _ => null,
            };
        }
    }
}