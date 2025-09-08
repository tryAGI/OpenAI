
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `error`.
    /// </summary>
    public enum RealtimeBetaServerEventErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventErrorType value)
        {
            return value switch
            {
                RealtimeBetaServerEventErrorType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventErrorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => RealtimeBetaServerEventErrorType.Error,
                _ => null,
            };
        }
    }
}