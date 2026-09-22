
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The amount of web search context made available to the model.
    /// </summary>
    public enum WebSearchContextSizeResource
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
    public static class WebSearchContextSizeResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchContextSizeResource value)
        {
            return value switch
            {
                WebSearchContextSizeResource.High => "high",
                WebSearchContextSizeResource.Low => "low",
                WebSearchContextSizeResource.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchContextSizeResource? ToEnum(string value)
        {
            return value switch
            {
                "high" => WebSearchContextSizeResource.High,
                "low" => WebSearchContextSizeResource.Low,
                "medium" => WebSearchContextSizeResource.Medium,
                _ => null,
            };
        }
    }
}