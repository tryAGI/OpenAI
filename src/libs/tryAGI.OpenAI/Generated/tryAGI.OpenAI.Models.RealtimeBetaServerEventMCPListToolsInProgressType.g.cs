
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `mcp_list_tools.in_progress`.
    /// </summary>
    public enum RealtimeBetaServerEventMCPListToolsInProgressType
    {
        /// <summary>
        /// 
        /// </summary>
        McpListToolsInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventMCPListToolsInProgressTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventMCPListToolsInProgressType value)
        {
            return value switch
            {
                RealtimeBetaServerEventMCPListToolsInProgressType.McpListToolsInProgress => "mcp_list_tools.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventMCPListToolsInProgressType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_list_tools.in_progress" => RealtimeBetaServerEventMCPListToolsInProgressType.McpListToolsInProgress,
                _ => null,
            };
        }
    }
}