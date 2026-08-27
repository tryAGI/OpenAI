
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.created`.
    /// </summary>
    public enum BetaResponseCreatedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCreatedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCreatedEventType value)
        {
            return value switch
            {
                BetaResponseCreatedEventType.ResponseCreated => "response.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCreatedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.created" => BetaResponseCreatedEventType.ResponseCreated,
                _ => null,
            };
        }
    }
}