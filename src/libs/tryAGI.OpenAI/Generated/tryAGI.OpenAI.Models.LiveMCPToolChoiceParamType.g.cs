
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: mcp
    /// </summary>
    public enum LiveMCPToolChoiceParamType
    {
        /// <summary>
        ///
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveMCPToolChoiceParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveMCPToolChoiceParamType value)
        {
            return value switch
            {
                LiveMCPToolChoiceParamType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveMCPToolChoiceParamType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => LiveMCPToolChoiceParamType.Mcp,
                _ => null,
            };
        }
    }
}