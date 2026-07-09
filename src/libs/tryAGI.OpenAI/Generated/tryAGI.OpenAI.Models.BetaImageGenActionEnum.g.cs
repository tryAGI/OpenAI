
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaImageGenActionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Edit,
        /// <summary>
        /// 
        /// </summary>
        Generate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaImageGenActionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageGenActionEnum value)
        {
            return value switch
            {
                BetaImageGenActionEnum.Auto => "auto",
                BetaImageGenActionEnum.Edit => "edit",
                BetaImageGenActionEnum.Generate => "generate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageGenActionEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaImageGenActionEnum.Auto,
                "edit" => BetaImageGenActionEnum.Edit,
                "generate" => BetaImageGenActionEnum.Generate,
                _ => null,
            };
        }
    }
}