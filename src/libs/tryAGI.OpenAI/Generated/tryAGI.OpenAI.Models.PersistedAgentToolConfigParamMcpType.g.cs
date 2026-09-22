
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `mcp`.<br/>
    /// Default Value: mcp
    /// </summary>
    public enum PersistedAgentToolConfigParamMcpType
    {
        /// <summary>
        ///
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersistedAgentToolConfigParamMcpTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedAgentToolConfigParamMcpType value)
        {
            return value switch
            {
                PersistedAgentToolConfigParamMcpType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedAgentToolConfigParamMcpType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => PersistedAgentToolConfigParamMcpType.Mcp,
                _ => null,
            };
        }
    }
}