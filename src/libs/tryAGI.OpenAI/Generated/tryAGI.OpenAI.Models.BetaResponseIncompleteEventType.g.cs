
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.incomplete`.
    /// </summary>
    public enum BetaResponseIncompleteEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseIncomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseIncompleteEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseIncompleteEventType value)
        {
            return value switch
            {
                BetaResponseIncompleteEventType.ResponseIncomplete => "response.incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseIncompleteEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.incomplete" => BetaResponseIncompleteEventType.ResponseIncomplete,
                _ => null,
            };
        }
    }
}