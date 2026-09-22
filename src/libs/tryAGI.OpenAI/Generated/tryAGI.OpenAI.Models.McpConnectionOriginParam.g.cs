
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Where outbound MCP HTTP connections originate.
    /// </summary>
    public enum McpConnectionOriginParam
    {
        /// <summary>
        ///
        /// </summary>
        Environment,
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class McpConnectionOriginParamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpConnectionOriginParam value)
        {
            return value switch
            {
                McpConnectionOriginParam.Environment => "environment",
                McpConnectionOriginParam.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpConnectionOriginParam? ToEnum(string value)
        {
            return value switch
            {
                "environment" => McpConnectionOriginParam.Environment,
                "service" => McpConnectionOriginParam.Service,
                _ => null,
            };
        }
    }
}