
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: program
    /// </summary>
    public enum ProgramToolCallCallerType
    {
        /// <summary>
        /// 
        /// </summary>
        Program,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProgramToolCallCallerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProgramToolCallCallerType value)
        {
            return value switch
            {
                ProgramToolCallCallerType.Program => "program",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProgramToolCallCallerType? ToEnum(string value)
        {
            return value switch
            {
                "program" => ProgramToolCallCallerType.Program,
                _ => null,
            };
        }
    }
}