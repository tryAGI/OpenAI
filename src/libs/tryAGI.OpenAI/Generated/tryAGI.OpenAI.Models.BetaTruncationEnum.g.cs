
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTruncationEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTruncationEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTruncationEnum value)
        {
            return value switch
            {
                BetaTruncationEnum.Auto => "auto",
                BetaTruncationEnum.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTruncationEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaTruncationEnum.Auto,
                "disabled" => BetaTruncationEnum.Disabled,
                _ => null,
            };
        }
    }
}