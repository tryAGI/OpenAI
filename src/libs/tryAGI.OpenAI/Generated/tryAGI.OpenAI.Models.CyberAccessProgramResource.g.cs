
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Cyber access program selected for a session.
    /// </summary>
    public enum CyberAccessProgramResource
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
    public static class CyberAccessProgramResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CyberAccessProgramResource value)
        {
            return value switch
            {
                CyberAccessProgramResource.DaybreakBlue => "daybreak_blue",
                CyberAccessProgramResource.DaybreakRed => "daybreak_red",
                CyberAccessProgramResource.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CyberAccessProgramResource? ToEnum(string value)
        {
            return value switch
            {
                "daybreak_blue" => CyberAccessProgramResource.DaybreakBlue,
                "daybreak_red" => CyberAccessProgramResource.DaybreakRed,
                "standard" => CyberAccessProgramResource.Standard,
                _ => null,
            };
        }
    }
}