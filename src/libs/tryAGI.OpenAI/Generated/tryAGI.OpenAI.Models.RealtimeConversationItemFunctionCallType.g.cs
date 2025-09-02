
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `function_call`.
    /// </summary>
    public enum RealtimeConversationItemFunctionCallType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemFunctionCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemFunctionCallType value)
        {
            return value switch
            {
                RealtimeConversationItemFunctionCallType.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemFunctionCallType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => RealtimeConversationItemFunctionCallType.FunctionCall,
                _ => null,
            };
        }
    }
}