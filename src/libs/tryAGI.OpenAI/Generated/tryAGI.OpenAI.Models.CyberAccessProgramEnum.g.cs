
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CyberAccessProgramEnum
    {
        /// <summary>
        ///
        /// </summary>
        DaybreakBlue,
        /// <summary>
        ///
        /// </summary>
        DaybreakRed,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CyberAccessProgramEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CyberAccessProgramEnum value)
        {
            return value switch
            {
                CyberAccessProgramEnum.DaybreakBlue => "daybreak_blue",
                CyberAccessProgramEnum.DaybreakRed => "daybreak_red",
                CyberAccessProgramEnum.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CyberAccessProgramEnum? ToEnum(string value)
        {
            return value switch
            {
                "daybreak_blue" => CyberAccessProgramEnum.DaybreakBlue,
                "daybreak_red" => CyberAccessProgramEnum.DaybreakRed,
                "standard" => CyberAccessProgramEnum.Standard,
                _ => null,
            };
        }
    }
}