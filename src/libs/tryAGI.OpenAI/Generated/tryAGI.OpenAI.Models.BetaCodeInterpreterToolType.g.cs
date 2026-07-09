
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the code interpreter tool. Always `code_interpreter`.
    /// </summary>
    public enum BetaCodeInterpreterToolType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCodeInterpreterToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCodeInterpreterToolType value)
        {
            return value switch
            {
                BetaCodeInterpreterToolType.CodeInterpreter => "code_interpreter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCodeInterpreterToolType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => BetaCodeInterpreterToolType.CodeInterpreter,
                _ => null,
            };
        }
    }
}