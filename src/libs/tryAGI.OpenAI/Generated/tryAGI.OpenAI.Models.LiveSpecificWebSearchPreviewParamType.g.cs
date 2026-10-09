
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool to call. Always `web_search_preview`.<br/>
    /// Default Value: web_search_preview
    /// </summary>
    public enum LiveSpecificWebSearchPreviewParamType
    {
        /// <summary>
        ///
        /// </summary>
        WebSearchPreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSpecificWebSearchPreviewParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSpecificWebSearchPreviewParamType value)
        {
            return value switch
            {
                LiveSpecificWebSearchPreviewParamType.WebSearchPreview => "web_search_preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSpecificWebSearchPreviewParamType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_preview" => LiveSpecificWebSearchPreviewParamType.WebSearchPreview,
                _ => null,
            };
        }
    }
}