
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `mcp_list_tools.failed`.
    /// </summary>
    public enum RealtimeBetaServerEventMCPListToolsFailedType
    {
        /// <summary>
        /// 
        /// </summary>
        McpListToolsFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventMCPListToolsFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventMCPListToolsFailedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventMCPListToolsFailedType.McpListToolsFailed => "mcp_list_tools.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventMCPListToolsFailedType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_list_tools.failed" => RealtimeBetaServerEventMCPListToolsFailedType.McpListToolsFailed,
                _ => null,
            };
        }
    }
}