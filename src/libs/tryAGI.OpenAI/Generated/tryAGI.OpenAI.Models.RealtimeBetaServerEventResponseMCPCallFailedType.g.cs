
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.mcp_call.failed`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseMCPCallFailedType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseMCPCallFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseMCPCallFailedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseMCPCallFailedType.ResponseMcpCallFailed => "response.mcp_call.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseMCPCallFailedType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call.failed" => RealtimeBetaServerEventResponseMCPCallFailedType.ResponseMcpCallFailed,
                _ => null,
            };
        }
    }
}