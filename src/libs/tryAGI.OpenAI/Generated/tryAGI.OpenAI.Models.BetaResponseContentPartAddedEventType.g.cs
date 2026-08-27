
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.content_part.added`.
    /// </summary>
    public enum BetaResponseContentPartAddedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseContentPartAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseContentPartAddedEventType value)
        {
            return value switch
            {
                BetaResponseContentPartAddedEventType.ResponseContentPartAdded => "response.content_part.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseContentPartAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.added" => BetaResponseContentPartAddedEventType.ResponseContentPartAdded,
                _ => null,
            };
        }
    }
}