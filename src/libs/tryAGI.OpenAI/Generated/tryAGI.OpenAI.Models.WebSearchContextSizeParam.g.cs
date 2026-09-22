
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The amount of web search context made available to the model.
    /// </summary>
    public enum WebSearchContextSizeParam
    {
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
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchContextSizeParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchContextSizeParam value)
        {
            return value switch
            {
                WebSearchContextSizeParam.High => "high",
                WebSearchContextSizeParam.Low => "low",
                WebSearchContextSizeParam.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchContextSizeParam? ToEnum(string value)
        {
            return value switch
            {
                "high" => WebSearchContextSizeParam.High,
                "low" => WebSearchContextSizeParam.Low,
                "medium" => WebSearchContextSizeParam.Medium,
                _ => null,
            };
        }
    }
}