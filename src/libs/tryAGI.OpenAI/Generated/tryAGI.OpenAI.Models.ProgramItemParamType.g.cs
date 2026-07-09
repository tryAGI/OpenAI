
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `program`.<br/>
    /// Default Value: program
    /// </summary>
    public enum ProgramItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Program,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProgramItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProgramItemParamType value)
        {
            return value switch
            {
                ProgramItemParamType.Program => "program",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProgramItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "program" => ProgramItemParamType.Program,
                _ => null,
            };
        }
    }
}