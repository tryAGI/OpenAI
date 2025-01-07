
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be "session.updated".<br/>
    /// Example: session.updated
    /// </summary>
    public enum RealtimeSessionUpdatedType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionUpdatedType value)
        {
            return value switch
            {
                RealtimeSessionUpdatedType.SessionUpdated => "session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.updated" => RealtimeSessionUpdatedType.SessionUpdated,
                _ => null,
            };
        }
    }
}