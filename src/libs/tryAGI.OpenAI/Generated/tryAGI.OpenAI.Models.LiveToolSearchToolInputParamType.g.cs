
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: tool_search
    /// </summary>
    public enum LiveToolSearchToolInputParamType
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveToolSearchToolInputParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveToolSearchToolInputParamType value)
        {
            return value switch
            {
                LiveToolSearchToolInputParamType.ToolSearch => "tool_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveToolSearchToolInputParamType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search" => LiveToolSearchToolInputParamType.ToolSearch,
                _ => null,
            };
        }
    }
}