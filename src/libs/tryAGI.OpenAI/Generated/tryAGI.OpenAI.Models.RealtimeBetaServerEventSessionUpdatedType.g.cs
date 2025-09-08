
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `session.updated`.
    /// </summary>
    public enum RealtimeBetaServerEventSessionUpdatedType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventSessionUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventSessionUpdatedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventSessionUpdatedType.SessionUpdated => "session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventSessionUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.updated" => RealtimeBetaServerEventSessionUpdatedType.SessionUpdated,
                _ => null,
            };
        }
    }
}