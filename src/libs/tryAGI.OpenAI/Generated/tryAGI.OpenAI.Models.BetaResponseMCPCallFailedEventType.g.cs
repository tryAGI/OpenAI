
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always 'response.mcp_call.failed'.
    /// </summary>
    public enum BetaResponseMCPCallFailedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseMcpCallFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseMCPCallFailedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseMCPCallFailedEventType value)
        {
            return value switch
            {
                BetaResponseMCPCallFailedEventType.ResponseMcpCallFailed => "response.mcp_call.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseMCPCallFailedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.failed" => BetaResponseMCPCallFailedEventType.ResponseMcpCallFailed,
                _ => null,
            };
        }
    }
}