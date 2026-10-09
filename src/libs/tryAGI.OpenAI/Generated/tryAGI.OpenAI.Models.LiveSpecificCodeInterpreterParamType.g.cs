
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool to call. Always `code_interpreter`.<br/>
    /// Default Value: code_interpreter
    /// </summary>
    public enum LiveSpecificCodeInterpreterParamType
    {
        /// <summary>
        ///
        /// </summary>
        CodeInterpreter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSpecificCodeInterpreterParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSpecificCodeInterpreterParamType value)
        {
            return value switch
            {
                LiveSpecificCodeInterpreterParamType.CodeInterpreter => "code_interpreter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSpecificCodeInterpreterParamType? ToEnum(string value)
        {
            return value switch
            {
                "code_interpreter" => LiveSpecificCodeInterpreterParamType.CodeInterpreter,
                _ => null,
            };
        }
    }
}