
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: mcp_protocol_error
    /// </summary>
    public enum BetaMCPProtocolErrorType
    {
        /// <summary>
        ///
        /// </summary>
        McpProtocolError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMCPProtocolErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMCPProtocolErrorType value)
        {
            return value switch
            {
                BetaMCPProtocolErrorType.McpProtocolError => "mcp_protocol_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMCPProtocolErrorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_protocol_error" => BetaMCPProtocolErrorType.McpProtocolError,
                _ => null,
            };
        }
    }
}