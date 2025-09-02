
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.mcp_call.failed`.
    /// </summary>
    public enum RealtimeServerEventResponseMCPCallFailedType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseMCPCallFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseMCPCallFailedType value)
        {
            return value switch
            {
                RealtimeServerEventResponseMCPCallFailedType.ResponseMcpCallFailed => "response.mcp_call.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseMCPCallFailedType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.failed" => RealtimeServerEventResponseMCPCallFailedType.ResponseMcpCallFailed,
                _ => null,
            };
        }
    }
}