
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `mcp`.<br/>
    /// Default Value: mcp
    /// </summary>
    public enum AgentToolConfigParamMcpType
    {
        /// <summary>
        ///
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentToolConfigParamMcpTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolConfigParamMcpType value)
        {
            return value switch
            {
                AgentToolConfigParamMcpType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolConfigParamMcpType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => AgentToolConfigParamMcpType.Mcp,
                _ => null,
            };
        }
    }
}