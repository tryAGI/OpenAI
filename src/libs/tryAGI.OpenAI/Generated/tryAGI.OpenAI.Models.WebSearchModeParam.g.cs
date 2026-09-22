
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The source used for web search results.
    /// </summary>
    public enum WebSearchModeParam
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
    public static class WebSearchModeParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchModeParam value)
        {
            return value switch
            {
                WebSearchModeParam.Cached => "cached",
                WebSearchModeParam.Disabled => "disabled",
                WebSearchModeParam.Live => "live",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchModeParam? ToEnum(string value)
        {
            return value switch
            {
                "cached" => WebSearchModeParam.Cached,
                "disabled" => WebSearchModeParam.Disabled,
                "live" => WebSearchModeParam.Live,
                _ => null,
            };
        }
    }
}