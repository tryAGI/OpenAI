
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `mcp_list_tools.failed`.
    /// </summary>
    public enum RealtimeServerEventMCPListToolsFailedType
    {
        /// <summary>
        /// 
        /// </summary>
        McpListToolsFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventMCPListToolsFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventMCPListToolsFailedType value)
        {
            return value switch
            {
                RealtimeServerEventMCPListToolsFailedType.McpListToolsFailed => "mcp_list_tools.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventMCPListToolsFailedType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_list_tools.failed" => RealtimeServerEventMCPListToolsFailedType.McpListToolsFailed,
                _ => null,
            };
        }
    }
}