
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `tool_search_call`.<br/>
    /// Default Value: tool_search_call
    /// </summary>
    public enum BetaToolSearchCallType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolSearchCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolSearchCallType value)
        {
            return value switch
            {
                BetaToolSearchCallType.ToolSearchCall => "tool_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolSearchCallType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_call" => BetaToolSearchCallType.ToolSearchCall,
                _ => null,
            };
        }
    }
}