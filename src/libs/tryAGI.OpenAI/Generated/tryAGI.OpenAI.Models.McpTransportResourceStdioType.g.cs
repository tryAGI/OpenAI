
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `stdio`.<br/>
    /// Default Value: stdio
    /// </summary>
    public enum McpTransportResourceStdioType
    {
        /// <summary>
        ///
        /// </summary>
        Stdio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpTransportResourceStdioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpTransportResourceStdioType value)
        {
            return value switch
            {
                McpTransportResourceStdioType.Stdio => "stdio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpTransportResourceStdioType? ToEnum(string value)
        {
            return value switch
            {
                "stdio" => McpTransportResourceStdioType.Stdio,
                _ => null,
            };
        }
    }
}