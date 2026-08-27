
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `program_output`.<br/>
    /// Default Value: program_output
    /// </summary>
    public enum ProgramOutputItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        ProgramOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProgramOutputItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProgramOutputItemParamType value)
        {
            return value switch
            {
                ProgramOutputItemParamType.ProgramOutput => "program_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProgramOutputItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "program_output" => ProgramOutputItemParamType.ProgramOutput,
                _ => null,
            };
        }
    }
}