
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
        Auto,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Original,
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
                DetailEnum.Auto => "auto",
                DetailEnum.High => "high",
                DetailEnum.Low => "low",
                DetailEnum.Original => "original",
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
                "auto" => DetailEnum.Auto,
                "high" => DetailEnum.High,
                "low" => DetailEnum.Low,
                "original" => DetailEnum.Original,
                _ => null,
            };
        }
    }
}