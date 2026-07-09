
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The caller type. Always `program`.<br/>
    /// Default Value: program
    /// </summary>
    public enum ProgramToolCallCallerParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Program,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProgramToolCallCallerParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProgramToolCallCallerParamType value)
        {
            return value switch
            {
                ProgramToolCallCallerParamType.Program => "program",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProgramToolCallCallerParamType? ToEnum(string value)
        {
            return value switch
            {
                "program" => ProgramToolCallCallerParamType.Program,
                _ => null,
            };
        }
    }
}