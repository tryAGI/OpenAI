
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `mcp_list_tools.completed`.
    /// </summary>
    public enum RealtimeServerEventMCPListToolsCompletedType
    {
        /// <summary>
        /// 
        /// </summary>
        McpListToolsCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventMCPListToolsCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventMCPListToolsCompletedType value)
        {
            return value switch
            {
                RealtimeServerEventMCPListToolsCompletedType.McpListToolsCompleted => "mcp_list_tools.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventMCPListToolsCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_list_tools.completed" => RealtimeServerEventMCPListToolsCompletedType.McpListToolsCompleted,
                _ => null,
            };
        }
    }
}