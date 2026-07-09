
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `mcp_list_tools`.
    /// </summary>
    public enum BetaMCPListToolsType
    {
        /// <summary>
        /// 
        /// </summary>
        McpListTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMCPListToolsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMCPListToolsType value)
        {
            return value switch
            {
                BetaMCPListToolsType.McpListTools => "mcp_list_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMCPListToolsType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_list_tools" => BetaMCPListToolsType.McpListTools,
                _ => null,
            };
        }
    }
}