
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `program_output`.<br/>
    /// Default Value: program_output
    /// </summary>
    public enum BetaProgramOutputItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        ProgramOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaProgramOutputItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaProgramOutputItemParamType value)
        {
            return value switch
            {
                BetaProgramOutputItemParamType.ProgramOutput => "program_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaProgramOutputItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "program_output" => BetaProgramOutputItemParamType.ProgramOutput,
                _ => null,
            };
        }
    }
}