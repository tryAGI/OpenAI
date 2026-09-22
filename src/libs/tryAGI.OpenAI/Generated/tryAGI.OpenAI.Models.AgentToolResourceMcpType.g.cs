
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `mcp`.<br/>
    /// Default Value: mcp
    /// </summary>
    public enum AgentToolResourceMcpType
    {
        /// <summary>
        ///
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentToolResourceMcpTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolResourceMcpType value)
        {
            return value switch
            {
                AgentToolResourceMcpType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolResourceMcpType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => AgentToolResourceMcpType.Mcp,
                _ => null,
            };
        }
    }
}