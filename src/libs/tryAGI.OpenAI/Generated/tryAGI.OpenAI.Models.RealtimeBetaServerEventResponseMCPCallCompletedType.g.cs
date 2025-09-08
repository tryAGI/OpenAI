
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.mcp_call.completed`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseMCPCallCompletedType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseMCPCallCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseMCPCallCompletedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseMCPCallCompletedType.ResponseMcpCallCompleted => "response.mcp_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseMCPCallCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.completed" => RealtimeBetaServerEventResponseMCPCallCompletedType.ResponseMcpCallCompleted,
                _ => null,
            };
        }
    }
}