
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCyberAccessProgramEnum
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
    public static class BetaCyberAccessProgramEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCyberAccessProgramEnum value)
        {
            return value switch
            {
                BetaCyberAccessProgramEnum.DaybreakBlue => "daybreak_blue",
                BetaCyberAccessProgramEnum.DaybreakRed => "daybreak_red",
                BetaCyberAccessProgramEnum.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCyberAccessProgramEnum? ToEnum(string value)
        {
            return value switch
            {
                "daybreak_blue" => BetaCyberAccessProgramEnum.DaybreakBlue,
                "daybreak_red" => BetaCyberAccessProgramEnum.DaybreakRed,
                "standard" => BetaCyberAccessProgramEnum.Standard,
                _ => null,
            };
        }
    }
}