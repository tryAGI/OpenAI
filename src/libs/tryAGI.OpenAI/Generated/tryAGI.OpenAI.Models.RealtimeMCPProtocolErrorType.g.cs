
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeMCPProtocolErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        ProtocolError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeMCPProtocolErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeMCPProtocolErrorType value)
        {
            return value switch
            {
                RealtimeMCPProtocolErrorType.ProtocolError => "protocol_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeMCPProtocolErrorType? ToEnum(string value)
        {
            return value switch
            {
                "protocol_error" => RealtimeMCPProtocolErrorType.ProtocolError,
                _ => null,
            };
        }
    }
}