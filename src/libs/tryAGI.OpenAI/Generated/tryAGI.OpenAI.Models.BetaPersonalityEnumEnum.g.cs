
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaPersonalityEnumEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Friendly,
        /// <summary>
        /// 
        /// </summary>
        Pragmatic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPersonalityEnumEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPersonalityEnumEnum value)
        {
            return value switch
            {
                BetaPersonalityEnumEnum.Friendly => "friendly",
                BetaPersonalityEnumEnum.Pragmatic => "pragmatic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPersonalityEnumEnum? ToEnum(string value)
        {
            return value switch
            {
                "friendly" => BetaPersonalityEnumEnum.Friendly,
                "pragmatic" => BetaPersonalityEnumEnum.Pragmatic,
                _ => null,
            };
        }
    }
}