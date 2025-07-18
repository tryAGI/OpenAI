
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always 'response.mcp_call_arguments.done'.
    /// </summary>
    public enum ResponseMCPCallArgumentsDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseMcpCallArgumentsDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMCPCallArgumentsDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMCPCallArgumentsDoneEventType value)
        {
            return value switch
            {
                ResponseMCPCallArgumentsDoneEventType.ResponseMcpCallArgumentsDone => "response.mcp_call_arguments.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMCPCallArgumentsDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.mcp_call_arguments.done" => ResponseMCPCallArgumentsDoneEventType.ResponseMcpCallArgumentsDone,
                _ => null,
            };
        }
    }
}