
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// For MCP tools, the type is always `mcp`.
    /// </summary>
    public enum ToolChoiceMCPType
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceMCPTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceMCPType value)
        {
            return value switch
            {
                ToolChoiceMCPType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceMCPType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => ToolChoiceMCPType.Mcp,
                _ => null,
            };
        }
    }
}