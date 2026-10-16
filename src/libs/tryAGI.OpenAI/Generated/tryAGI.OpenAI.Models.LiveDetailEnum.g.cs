
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDetailEnum
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
    public static class LiveDetailEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDetailEnum value)
        {
            return value switch
            {
                LiveDetailEnum.Auto => "auto",
                LiveDetailEnum.High => "high",
                LiveDetailEnum.Low => "low",
                LiveDetailEnum.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDetailEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => LiveDetailEnum.Auto,
                "high" => LiveDetailEnum.High,
                "low" => LiveDetailEnum.Low,
                "original" => LiveDetailEnum.Original,
                _ => null,
            };
        }
    }
}