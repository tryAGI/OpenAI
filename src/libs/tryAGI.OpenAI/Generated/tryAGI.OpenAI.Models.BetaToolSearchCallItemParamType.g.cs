
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `tool_search_call`.<br/>
    /// Default Value: tool_search_call
    /// </summary>
    public enum BetaToolSearchCallItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolSearchCallItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolSearchCallItemParamType value)
        {
            return value switch
            {
                BetaToolSearchCallItemParamType.ToolSearchCall => "tool_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolSearchCallItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_call" => BetaToolSearchCallItemParamType.ToolSearchCall,
                _ => null,
            };
        }
    }
}