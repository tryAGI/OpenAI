
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `function_call_output`.
    /// </summary>
    public enum RealtimeConversationItemFunctionCallOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemFunctionCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemFunctionCallOutputType value)
        {
            return value switch
            {
                RealtimeConversationItemFunctionCallOutputType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemFunctionCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => RealtimeConversationItemFunctionCallOutputType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}