
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always 'response.mcp_call_arguments.delta'.
    /// </summary>
    public enum ResponseMCPCallArgumentsDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallArgumentsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMCPCallArgumentsDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMCPCallArgumentsDeltaEventType value)
        {
            return value switch
            {
                ResponseMCPCallArgumentsDeltaEventType.ResponseMcpCallArgumentsDelta => "response.mcp_call_arguments.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMCPCallArgumentsDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call_arguments.delta" => ResponseMCPCallArgumentsDeltaEventType.ResponseMcpCallArgumentsDelta,
                _ => null,
            };
        }
    }
}