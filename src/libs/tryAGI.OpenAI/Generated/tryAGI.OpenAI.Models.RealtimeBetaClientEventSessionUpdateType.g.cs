
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `session.update`.
    /// </summary>
    public enum RealtimeBetaClientEventSessionUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaClientEventSessionUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaClientEventSessionUpdateType value)
        {
            return value switch
            {
                RealtimeBetaClientEventSessionUpdateType.SessionUpdate => "session.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaClientEventSessionUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "session.update" => RealtimeBetaClientEventSessionUpdateType.SessionUpdate,
                _ => null,
            };
        }
    }
}