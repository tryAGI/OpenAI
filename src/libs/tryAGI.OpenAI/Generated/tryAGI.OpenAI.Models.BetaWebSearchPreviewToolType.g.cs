
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the web search tool. One of `web_search_preview` or `web_search_preview_2025_03_11`.<br/>
    /// Default Value: web_search_preview
    /// </summary>
    public enum BetaWebSearchPreviewToolType
    {
        /// <summary>
        ///
        /// </summary>
        WebSearchPreview,
        /// <summary>
        ///
        /// </summary>
        WebSearchPreview20250311,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebSearchPreviewToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebSearchPreviewToolType value)
        {
            return value switch
            {
                BetaWebSearchPreviewToolType.WebSearchPreview => "web_search_preview",
                BetaWebSearchPreviewToolType.WebSearchPreview20250311 => "web_search_preview_2025_03_11",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebSearchPreviewToolType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_preview" => BetaWebSearchPreviewToolType.WebSearchPreview,
                "web_search_preview_2025_03_11" => BetaWebSearchPreviewToolType.WebSearchPreview20250311,
                _ => null,
            };
        }
    }
}