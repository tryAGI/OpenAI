
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `stdio`.<br/>
    /// Default Value: stdio
    /// </summary>
    public enum PersistedMcpTransportConfigParamStdioType
    {
        /// <summary>
        ///
        /// </summary>
        Stdio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersistedMcpTransportConfigParamStdioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedMcpTransportConfigParamStdioType value)
        {
            return value switch
            {
                PersistedMcpTransportConfigParamStdioType.Stdio => "stdio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedMcpTransportConfigParamStdioType? ToEnum(string value)
        {
            return value switch
            {
                "stdio" => PersistedMcpTransportConfigParamStdioType.Stdio,
                _ => null,
            };
        }
    }
}