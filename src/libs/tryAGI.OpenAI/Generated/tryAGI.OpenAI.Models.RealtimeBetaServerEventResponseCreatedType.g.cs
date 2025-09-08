
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.created`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseCreatedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseCreatedType.ResponseCreated => "response.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "response.created" => RealtimeBetaServerEventResponseCreatedType.ResponseCreated,
                _ => null,
            };
        }
    }
}