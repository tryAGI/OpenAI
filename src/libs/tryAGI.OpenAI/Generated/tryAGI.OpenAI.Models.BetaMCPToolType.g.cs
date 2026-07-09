
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the MCP tool. Always `mcp`.
    /// </summary>
    public enum BetaMCPToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMCPToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMCPToolType value)
        {
            return value switch
            {
                BetaMCPToolType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMCPToolType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => BetaMCPToolType.Mcp,
                _ => null,
            };
        }
    }
}