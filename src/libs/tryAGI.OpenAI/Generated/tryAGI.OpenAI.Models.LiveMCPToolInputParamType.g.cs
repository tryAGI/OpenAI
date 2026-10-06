
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: mcp
    /// </summary>
    public enum LiveMCPToolInputParamType
    {
        /// <summary>
        ///
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveMCPToolInputParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveMCPToolInputParamType value)
        {
            return value switch
            {
                LiveMCPToolInputParamType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveMCPToolInputParamType? ToEnum(string value)
        {
            return value switch
            {
                "mcp" => LiveMCPToolInputParamType.Mcp,
                _ => null,
            };
        }
    }
}