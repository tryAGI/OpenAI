
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpendLimitIntervalEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Month,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpendLimitIntervalEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpendLimitIntervalEnum value)
        {
            return value switch
            {
                SpendLimitIntervalEnum.Month => "month",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpendLimitIntervalEnum? ToEnum(string value)
        {
            return value switch
            {
                "month" => SpendLimitIntervalEnum.Month,
                _ => null,
            };
        }
    }
}