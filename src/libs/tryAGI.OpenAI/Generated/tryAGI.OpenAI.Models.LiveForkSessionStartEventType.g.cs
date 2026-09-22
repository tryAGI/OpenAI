
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The Live client event type. Always `session.start`.<br/>
    /// Default Value: session.start
    /// </summary>
    public enum LiveForkSessionStartEventType
    {
        /// <summary>
        ///
        /// </summary>
        SessionStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveForkSessionStartEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveForkSessionStartEventType value)
        {
            return value switch
            {
                LiveForkSessionStartEventType.SessionStart => "session.start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveForkSessionStartEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.start" => LiveForkSessionStartEventType.SessionStart,
                _ => null,
            };
        }
    }
}