
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `mcp_list_tools`.
    /// </summary>
    public enum RealtimeMCPListToolsType
    {
        /// <summary>
        /// 
        /// </summary>
        McpListTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeMCPListToolsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeMCPListToolsType value)
        {
            return value switch
            {
                RealtimeMCPListToolsType.McpListTools => "mcp_list_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeMCPListToolsType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_list_tools" => RealtimeMCPListToolsType.McpListTools,
                _ => null,
            };
        }
    }
}