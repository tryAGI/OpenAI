
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.mcp_call.completed`.
    /// </summary>
    public enum RealtimeServerEventResponseMCPCallCompletedType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseMCPCallCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseMCPCallCompletedType value)
        {
            return value switch
            {
                RealtimeServerEventResponseMCPCallCompletedType.ResponseMcpCallCompleted => "response.mcp_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseMCPCallCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.completed" => RealtimeServerEventResponseMCPCallCompletedType.ResponseMcpCallCompleted,
                _ => null,
            };
        }
    }
}