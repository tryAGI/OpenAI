
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum DetailEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DetailEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetailEnum value)
        {
            return value switch
            {
                DetailEnum.Low => "low",
                DetailEnum.High => "high",
                DetailEnum.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetailEnum? ToEnum(string value)
        {
            return value switch
            {
                "low" => DetailEnum.Low,
                "high" => DetailEnum.High,
                "auto" => DetailEnum.Auto,
                _ => null,
            };
        }
    }
}