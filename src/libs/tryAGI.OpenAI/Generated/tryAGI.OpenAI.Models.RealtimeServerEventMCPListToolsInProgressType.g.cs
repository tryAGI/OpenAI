
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `mcp_list_tools.in_progress`.
    /// </summary>
    public enum RealtimeServerEventMCPListToolsInProgressType
    {
        /// <summary>
        /// 
        /// </summary>
        McpListToolsInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventMCPListToolsInProgressTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventMCPListToolsInProgressType value)
        {
            return value switch
            {
                RealtimeServerEventMCPListToolsInProgressType.McpListToolsInProgress => "mcp_list_tools.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventMCPListToolsInProgressType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_list_tools.in_progress" => RealtimeServerEventMCPListToolsInProgressType.McpListToolsInProgress,
                _ => null,
            };
        }
    }
}