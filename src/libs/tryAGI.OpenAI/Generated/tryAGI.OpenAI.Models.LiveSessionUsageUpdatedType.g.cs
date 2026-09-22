
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `session.usage.updated`.<br/>
    /// Default Value: session.usage.updated
    /// </summary>
    public enum LiveSessionUsageUpdatedType
    {
        /// <summary>
        ///
        /// </summary>
        SessionUsageUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionUsageUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionUsageUpdatedType value)
        {
            return value switch
            {
                LiveSessionUsageUpdatedType.SessionUsageUpdated => "session.usage.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionUsageUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.usage.updated" => LiveSessionUsageUpdatedType.SessionUsageUpdated,
                _ => null,
            };
        }
    }
}