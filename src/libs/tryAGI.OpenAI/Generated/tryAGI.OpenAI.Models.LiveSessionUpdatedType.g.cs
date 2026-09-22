
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `session.updated`.<br/>
    /// Default Value: session.updated
    /// </summary>
    public enum LiveSessionUpdatedType
    {
        /// <summary>
        ///
        /// </summary>
        SessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionUpdatedType value)
        {
            return value switch
            {
                LiveSessionUpdatedType.SessionUpdated => "session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.updated" => LiveSessionUpdatedType.SessionUpdated,
                _ => null,
            };
        }
    }
}