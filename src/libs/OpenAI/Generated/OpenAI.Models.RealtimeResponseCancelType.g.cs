
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "response.cancel".<br/>
    /// Example: response.cancel
    /// </summary>
    public enum RealtimeResponseCancelType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCancel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseCancelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseCancelType value)
        {
            return value switch
            {
                RealtimeResponseCancelType.ResponseCancel => "response.cancel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseCancelType? ToEnum(string value)
        {
            return value switch
            {
                "response.cancel" => RealtimeResponseCancelType.ResponseCancel,
                _ => null,
            };
        }
    }
}