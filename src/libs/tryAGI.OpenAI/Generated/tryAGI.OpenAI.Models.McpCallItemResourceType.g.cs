
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `mcp_call`.<br/>
    /// Default Value: mcp_call
    /// </summary>
    public enum McpCallItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        McpCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpCallItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpCallItemResourceType value)
        {
            return value switch
            {
                McpCallItemResourceType.McpCall => "mcp_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpCallItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_call" => McpCallItemResourceType.McpCall,
                _ => null,
            };
        }
    }
}