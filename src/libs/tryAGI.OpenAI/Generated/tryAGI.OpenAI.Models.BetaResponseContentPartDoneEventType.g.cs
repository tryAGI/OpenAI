
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.content_part.done`.
    /// </summary>
    public enum BetaResponseContentPartDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseContentPartDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseContentPartDoneEventType value)
        {
            return value switch
            {
                BetaResponseContentPartDoneEventType.ResponseContentPartDone => "response.content_part.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseContentPartDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.done" => BetaResponseContentPartDoneEventType.ResponseContentPartDone,
                _ => null,
            };
        }
    }
}