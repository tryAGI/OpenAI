
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `tool_search_output`.<br/>
    /// Default Value: tool_search_output
    /// </summary>
    public enum ToolSearchOutputItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearchOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchOutputItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchOutputItemParamType value)
        {
            return value switch
            {
                ToolSearchOutputItemParamType.ToolSearchOutput => "tool_search_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchOutputItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_output" => ToolSearchOutputItemParamType.ToolSearchOutput,
                _ => null,
            };
        }
    }
}