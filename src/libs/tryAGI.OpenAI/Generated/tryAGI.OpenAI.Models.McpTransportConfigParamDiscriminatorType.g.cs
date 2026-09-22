
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum McpTransportConfigParamDiscriminatorType
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
    public static class McpTransportConfigParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpTransportConfigParamDiscriminatorType value)
        {
            return value switch
            {
                McpTransportConfigParamDiscriminatorType.Http => "http",
                McpTransportConfigParamDiscriminatorType.Stdio => "stdio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpTransportConfigParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "http" => McpTransportConfigParamDiscriminatorType.Http,
                "stdio" => McpTransportConfigParamDiscriminatorType.Stdio,
                _ => null,
            };
        }
    }
}