
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `stdio`.<br/>
    /// Default Value: stdio
    /// </summary>
    public enum PersistedMcpTransportResourceStdioType
    {
        /// <summary>
        ///
        /// </summary>
        Stdio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersistedMcpTransportResourceStdioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedMcpTransportResourceStdioType value)
        {
            return value switch
            {
                PersistedMcpTransportResourceStdioType.Stdio => "stdio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedMcpTransportResourceStdioType? ToEnum(string value)
        {
            return value switch
            {
                "stdio" => PersistedMcpTransportResourceStdioType.Stdio,
                _ => null,
            };
        }
    }
}