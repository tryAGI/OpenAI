
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the tool. Always `tool_search`.<br/>
    /// Default Value: tool_search
    /// </summary>
    public enum ToolSearchToolParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchToolParamType value)
        {
            return value switch
            {
                ToolSearchToolParamType.ToolSearch => "tool_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search" => ToolSearchToolParamType.ToolSearch,
                _ => null,
            };
        }
    }
}