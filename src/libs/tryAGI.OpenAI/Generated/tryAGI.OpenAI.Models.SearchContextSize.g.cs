
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchContextSize
    {
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        High,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchContextSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchContextSize value)
        {
            return value switch
            {
                SearchContextSize.Low => "low",
                SearchContextSize.Medium => "medium",
                SearchContextSize.High => "high",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchContextSize? ToEnum(string value)
        {
            return value switch
            {
                "low" => SearchContextSize.Low,
                "medium" => SearchContextSize.Medium,
                "high" => SearchContextSize.High,
                _ => null,
            };
        }
    }
}