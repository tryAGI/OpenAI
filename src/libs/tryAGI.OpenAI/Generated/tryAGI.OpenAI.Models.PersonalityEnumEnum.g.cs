
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum PersonalityEnumEnum
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
    public static class PersonalityEnumEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersonalityEnumEnum value)
        {
            return value switch
            {
                PersonalityEnumEnum.Friendly => "friendly",
                PersonalityEnumEnum.Pragmatic => "pragmatic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersonalityEnumEnum? ToEnum(string value)
        {
            return value switch
            {
                "friendly" => PersonalityEnumEnum.Friendly,
                "pragmatic" => PersonalityEnumEnum.Pragmatic,
                _ => null,
            };
        }
    }
}