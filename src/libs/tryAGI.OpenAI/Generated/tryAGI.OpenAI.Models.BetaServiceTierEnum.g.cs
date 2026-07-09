
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaServiceTierEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Flex,
        /// <summary>
        /// 
        /// </summary>
        Priority,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaServiceTierEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaServiceTierEnum value)
        {
            return value switch
            {
                BetaServiceTierEnum.Auto => "auto",
                BetaServiceTierEnum.Default => "default",
                BetaServiceTierEnum.Flex => "flex",
                BetaServiceTierEnum.Priority => "priority",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaServiceTierEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaServiceTierEnum.Auto,
                "default" => BetaServiceTierEnum.Default,
                "flex" => BetaServiceTierEnum.Flex,
                "priority" => BetaServiceTierEnum.Priority,
                _ => null,
            };
        }
    }
}