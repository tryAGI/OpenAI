
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.mcp_call_arguments.delta`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseMCPCallArgumentsDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallArgumentsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseMCPCallArgumentsDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseMCPCallArgumentsDeltaType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseMCPCallArgumentsDeltaType.ResponseMcpCallArgumentsDelta => "response.mcp_call_arguments.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseMCPCallArgumentsDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call_arguments.delta" => RealtimeBetaServerEventResponseMCPCallArgumentsDeltaType.ResponseMcpCallArgumentsDelta,
                _ => null,
            };
        }
    }
}