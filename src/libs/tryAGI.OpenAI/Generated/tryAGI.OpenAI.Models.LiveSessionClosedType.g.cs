
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `session.closed`.<br/>
    /// Default Value: session.closed
    /// </summary>
    public enum LiveSessionClosedType
    {
        /// <summary>
        ///
        /// </summary>
        SessionClosed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionClosedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionClosedType value)
        {
            return value switch
            {
                LiveSessionClosedType.SessionClosed => "session.closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionClosedType? ToEnum(string value)
        {
            return value switch
            {
                "session.closed" => LiveSessionClosedType.SessionClosed,
                _ => null,
            };
        }
    }
}