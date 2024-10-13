
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "session.update".<br/>
    /// Example: session.update
    /// </summary>
    public enum RealtimeSessionUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionUpdateType value)
        {
            return value switch
            {
                RealtimeSessionUpdateType.SessionUpdate => "session.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "session.update" => RealtimeSessionUpdateType.SessionUpdate,
                _ => null,
            };
        }
    }
}