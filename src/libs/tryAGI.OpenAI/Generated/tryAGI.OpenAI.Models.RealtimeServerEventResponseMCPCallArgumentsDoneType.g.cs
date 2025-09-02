
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.mcp_call_arguments.done`.
    /// </summary>
    public enum RealtimeServerEventResponseMCPCallArgumentsDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallArgumentsDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseMCPCallArgumentsDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseMCPCallArgumentsDoneType value)
        {
            return value switch
            {
                RealtimeServerEventResponseMCPCallArgumentsDoneType.ResponseMcpCallArgumentsDone => "response.mcp_call_arguments.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseMCPCallArgumentsDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call_arguments.done" => RealtimeServerEventResponseMCPCallArgumentsDoneType.ResponseMcpCallArgumentsDone,
                _ => null,
            };
        }
    }
}