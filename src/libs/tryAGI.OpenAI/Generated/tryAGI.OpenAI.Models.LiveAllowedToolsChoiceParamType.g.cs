
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool choice type. Always `allowed_tools`.<br/>
    /// Default Value: allowed_tools
    /// </summary>
    public enum LiveAllowedToolsChoiceParamType
    {
        /// <summary>
        ///
        /// </summary>
        AllowedTools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveAllowedToolsChoiceParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveAllowedToolsChoiceParamType value)
        {
            return value switch
            {
                LiveAllowedToolsChoiceParamType.AllowedTools => "allowed_tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveAllowedToolsChoiceParamType? ToEnum(string value)
        {
            return value switch
            {
                "allowed_tools" => LiveAllowedToolsChoiceParamType.AllowedTools,
                _ => null,
            };
        }
    }
}