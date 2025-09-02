
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.mcp_call.in_progress`.
    /// </summary>
    public enum RealtimeServerEventResponseMCPCallInProgressType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseMCPCallInProgressTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseMCPCallInProgressType value)
        {
            return value switch
            {
                RealtimeServerEventResponseMCPCallInProgressType.ResponseMcpCallInProgress => "response.mcp_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseMCPCallInProgressType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.in_progress" => RealtimeServerEventResponseMCPCallInProgressType.ResponseMcpCallInProgress,
                _ => null,
            };
        }
    }
}