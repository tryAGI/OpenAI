
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// For MCP tools, the type is always `mcp`.
    /// </summary>
    public enum BetaToolChoiceMCPType
    {
        /// <summary>
        /// 
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolChoiceMCPTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolChoiceMCPType value)
        {
            return value switch
            {
                BetaToolChoiceMCPType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolChoiceMCPType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => BetaToolChoiceMCPType.Mcp,
                _ => null,
            };
        }
    }
}