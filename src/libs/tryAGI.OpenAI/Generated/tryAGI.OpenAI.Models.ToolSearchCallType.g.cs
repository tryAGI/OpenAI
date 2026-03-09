
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `tool_search_call`.<br/>
    /// Default Value: tool_search_call
    /// </summary>
    public enum ToolSearchCallType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchCallType value)
        {
            return value switch
            {
                ToolSearchCallType.ToolSearchCall => "tool_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchCallType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_call" => ToolSearchCallType.ToolSearchCall,
                _ => null,
            };
        }
    }
}