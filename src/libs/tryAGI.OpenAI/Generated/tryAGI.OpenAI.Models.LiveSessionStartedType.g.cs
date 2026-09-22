
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `session.started`.<br/>
    /// Default Value: session.started
    /// </summary>
    public enum LiveSessionStartedType
    {
        /// <summary>
        ///
        /// </summary>
        SessionStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionStartedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionStartedType value)
        {
            return value switch
            {
                LiveSessionStartedType.SessionStarted => "session.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionStartedType? ToEnum(string value)
        {
            return value switch
            {
                "session.started" => LiveSessionStartedType.SessionStarted,
                _ => null,
            };
        }
    }
}