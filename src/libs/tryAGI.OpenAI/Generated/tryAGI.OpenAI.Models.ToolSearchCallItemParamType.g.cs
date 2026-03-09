
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `tool_search_call`.<br/>
    /// Default Value: tool_search_call
    /// </summary>
    public enum ToolSearchCallItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchCallItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchCallItemParamType value)
        {
            return value switch
            {
                ToolSearchCallItemParamType.ToolSearchCall => "tool_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchCallItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_call" => ToolSearchCallItemParamType.ToolSearchCall,
                _ => null,
            };
        }
    }
}