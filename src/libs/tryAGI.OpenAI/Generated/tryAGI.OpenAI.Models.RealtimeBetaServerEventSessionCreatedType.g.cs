
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `session.created`.
    /// </summary>
    public enum RealtimeBetaServerEventSessionCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventSessionCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventSessionCreatedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventSessionCreatedType.SessionCreated => "session.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventSessionCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.created" => RealtimeBetaServerEventSessionCreatedType.SessionCreated,
                _ => null,
            };
        }
    }
}