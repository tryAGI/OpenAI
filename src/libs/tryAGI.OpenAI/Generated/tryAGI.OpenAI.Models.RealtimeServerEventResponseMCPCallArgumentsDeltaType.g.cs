
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.mcp_call_arguments.delta`.
    /// </summary>
    public enum RealtimeServerEventResponseMCPCallArgumentsDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallArgumentsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseMCPCallArgumentsDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseMCPCallArgumentsDeltaType value)
        {
            return value switch
            {
                RealtimeServerEventResponseMCPCallArgumentsDeltaType.ResponseMcpCallArgumentsDelta => "response.mcp_call_arguments.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseMCPCallArgumentsDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call_arguments.delta" => RealtimeServerEventResponseMCPCallArgumentsDeltaType.ResponseMcpCallArgumentsDelta,
                _ => null,
            };
        }
    }
}