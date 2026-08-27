
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.refusal.done`.
    /// </summary>
    public enum BetaResponseRefusalDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseRefusalDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseRefusalDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseRefusalDoneEventType value)
        {
            return value switch
            {
                BetaResponseRefusalDoneEventType.ResponseRefusalDone => "response.refusal.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseRefusalDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.refusal.done" => BetaResponseRefusalDoneEventType.ResponseRefusalDone,
                _ => null,
            };
        }
    }
}