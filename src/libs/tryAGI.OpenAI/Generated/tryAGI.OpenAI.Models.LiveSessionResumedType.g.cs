
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: session.resumed
    /// </summary>
    public enum LiveSessionResumedType
    {
        /// <summary>
        ///
        /// </summary>
        SessionResumed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionResumedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionResumedType value)
        {
            return value switch
            {
                LiveSessionResumedType.SessionResumed => "session.resumed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionResumedType? ToEnum(string value)
        {
            return value switch
            {
                "session.resumed" => LiveSessionResumedType.SessionResumed,
                _ => null,
            };
        }
    }
}