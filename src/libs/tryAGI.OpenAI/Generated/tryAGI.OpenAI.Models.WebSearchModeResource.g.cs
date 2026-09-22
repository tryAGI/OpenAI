
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The source used for web search results.
    /// </summary>
    public enum WebSearchModeResource
    {
        /// <summary>
        ///
        /// </summary>
        Cached,
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Live,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchModeResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchModeResource value)
        {
            return value switch
            {
                WebSearchModeResource.Cached => "cached",
                WebSearchModeResource.Disabled => "disabled",
                WebSearchModeResource.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchModeResource? ToEnum(string value)
        {
            return value switch
            {
                "cached" => WebSearchModeResource.Cached,
                "disabled" => WebSearchModeResource.Disabled,
                "live" => WebSearchModeResource.Live,
                _ => null,
            };
        }
    }
}