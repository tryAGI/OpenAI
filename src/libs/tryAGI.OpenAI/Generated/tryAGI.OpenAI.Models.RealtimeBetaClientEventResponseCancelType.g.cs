
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.cancel`.
    /// </summary>
    public enum RealtimeBetaClientEventResponseCancelType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCancel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaClientEventResponseCancelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaClientEventResponseCancelType value)
        {
            return value switch
            {
                RealtimeBetaClientEventResponseCancelType.ResponseCancel => "response.cancel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaClientEventResponseCancelType? ToEnum(string value)
        {
            return value switch
            {
                "response.cancel" => RealtimeBetaClientEventResponseCancelType.ResponseCancel,
                _ => null,
            };
        }
    }
}