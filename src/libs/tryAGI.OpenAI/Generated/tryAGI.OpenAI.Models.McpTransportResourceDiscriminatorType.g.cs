
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum McpTransportResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Http,
        /// <summary>
        ///
        /// </summary>
        Stdio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpTransportResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpTransportResourceDiscriminatorType value)
        {
            return value switch
            {
                McpTransportResourceDiscriminatorType.Http => "http",
                McpTransportResourceDiscriminatorType.Stdio => "stdio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpTransportResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "http" => McpTransportResourceDiscriminatorType.Http,
                "stdio" => McpTransportResourceDiscriminatorType.Stdio,
                _ => null,
            };
        }
    }
}