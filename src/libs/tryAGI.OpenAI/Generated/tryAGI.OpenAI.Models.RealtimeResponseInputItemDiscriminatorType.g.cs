
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum RealtimeResponseInputItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
        /// <summary>
        ///
        /// </summary>
        FunctionCallOutput,
        /// <summary>
        ///
        /// </summary>
        ItemReference,
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseInputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseInputItemDiscriminatorType value)
        {
            return value switch
            {
                RealtimeResponseInputItemDiscriminatorType.FunctionCall => "function_call",
                RealtimeResponseInputItemDiscriminatorType.FunctionCallOutput => "function_call_output",
                RealtimeResponseInputItemDiscriminatorType.ItemReference => "item_reference",
                RealtimeResponseInputItemDiscriminatorType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseInputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => RealtimeResponseInputItemDiscriminatorType.FunctionCall,
                "function_call_output" => RealtimeResponseInputItemDiscriminatorType.FunctionCallOutput,
                "item_reference" => RealtimeResponseInputItemDiscriminatorType.ItemReference,
                "message" => RealtimeResponseInputItemDiscriminatorType.Message,
                _ => null,
            };
        }
    }
}