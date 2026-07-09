
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always 'response.mcp_call.in_progress'.
    /// </summary>
    public enum BetaResponseMCPCallInProgressEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseMCPCallInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseMCPCallInProgressEventType value)
        {
            return value switch
            {
                BetaResponseMCPCallInProgressEventType.ResponseMcpCallInProgress => "response.mcp_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseMCPCallInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.in_progress" => BetaResponseMCPCallInProgressEventType.ResponseMcpCallInProgress,
                _ => null,
            };
        }
    }
}