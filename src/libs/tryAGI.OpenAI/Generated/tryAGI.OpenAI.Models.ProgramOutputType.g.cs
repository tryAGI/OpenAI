
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `program_output`.<br/>
    /// Default Value: program_output
    /// </summary>
    public enum ProgramOutputType
    {
        /// <summary>
        ///
        /// </summary>
        ProgramOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProgramOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProgramOutputType value)
        {
            return value switch
            {
                ProgramOutputType.ProgramOutput => "program_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProgramOutputType? ToEnum(string value)
        {
            return value switch
            {
                "program_output" => ProgramOutputType.ProgramOutput,
                _ => null,
            };
        }
    }
}