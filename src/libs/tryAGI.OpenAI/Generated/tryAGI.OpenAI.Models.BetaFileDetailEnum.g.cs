
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFileDetailEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFileDetailEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFileDetailEnum value)
        {
            return value switch
            {
                BetaFileDetailEnum.Auto => "auto",
                BetaFileDetailEnum.High => "high",
                BetaFileDetailEnum.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFileDetailEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => BetaFileDetailEnum.Auto,
                "high" => BetaFileDetailEnum.High,
                "low" => BetaFileDetailEnum.Low,
                _ => null,
            };
        }
    }
}