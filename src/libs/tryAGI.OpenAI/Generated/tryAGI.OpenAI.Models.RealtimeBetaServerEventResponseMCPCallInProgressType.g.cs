
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.mcp_call.in_progress`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseMCPCallInProgressType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseMCPCallInProgressTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseMCPCallInProgressType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseMCPCallInProgressType.ResponseMcpCallInProgress => "response.mcp_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseMCPCallInProgressType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.in_progress" => RealtimeBetaServerEventResponseMCPCallInProgressType.ResponseMcpCallInProgress,
                _ => null,
            };
        }
    }
}