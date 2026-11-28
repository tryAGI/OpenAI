
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Cyber access program selected for a session.
    /// </summary>
    public enum CyberAccessProgramParam
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
    public static class CyberAccessProgramParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CyberAccessProgramParam value)
        {
            return value switch
            {
                CyberAccessProgramParam.DaybreakBlue => "daybreak_blue",
                CyberAccessProgramParam.DaybreakRed => "daybreak_red",
                CyberAccessProgramParam.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CyberAccessProgramParam? ToEnum(string value)
        {
            return value switch
            {
                "daybreak_blue" => CyberAccessProgramParam.DaybreakBlue,
                "daybreak_red" => CyberAccessProgramParam.DaybreakRed,
                "standard" => CyberAccessProgramParam.Standard,
                _ => null,
            };
        }
    }
}