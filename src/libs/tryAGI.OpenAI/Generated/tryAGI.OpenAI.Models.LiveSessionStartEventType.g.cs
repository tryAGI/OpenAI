
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The Live client event type. Always `session.start`.<br/>
    /// Default Value: session.start
    /// </summary>
    public enum LiveSessionStartEventType
    {
        /// <summary>
        ///
        /// </summary>
        SessionStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionStartEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionStartEventType value)
        {
            return value switch
            {
                LiveSessionStartEventType.SessionStart => "session.start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionStartEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.start" => LiveSessionStartEventType.SessionStart,
                _ => null,
            };
        }
    }
}