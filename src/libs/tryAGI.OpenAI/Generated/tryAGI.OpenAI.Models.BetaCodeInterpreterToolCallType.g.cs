
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the code interpreter tool call. Always `code_interpreter_call`.<br/>
    /// Default Value: code_interpreter_call
    /// </summary>
    public enum BetaCodeInterpreterToolCallType
    {
        /// <summary>
        ///
        /// </summary>
        CodeInterpreterCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCodeInterpreterToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCodeInterpreterToolCallType value)
        {
            return value switch
            {
                BetaCodeInterpreterToolCallType.CodeInterpreterCall => "code_interpreter_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCodeInterpreterToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter_call" => BetaCodeInterpreterToolCallType.CodeInterpreterCall,
                _ => null,
            };
        }
    }
}