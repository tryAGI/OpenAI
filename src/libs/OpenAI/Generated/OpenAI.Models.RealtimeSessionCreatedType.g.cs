
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "session.created".<br/>
    /// Example: session.created
    /// </summary>
    public enum RealtimeSessionCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreatedType value)
        {
            return value switch
            {
                RealtimeSessionCreatedType.SessionCreated => "session.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "session.created" => RealtimeSessionCreatedType.SessionCreated,
                _ => null,
            };
        }
    }
}