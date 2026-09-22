
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Where outbound MCP HTTP connections originate.
    /// </summary>
    public enum McpConnectionOriginResource
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
    public static class McpConnectionOriginResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this McpConnectionOriginResource value)
        {
            return value switch
            {
                McpConnectionOriginResource.Environment => "environment",
                McpConnectionOriginResource.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static McpConnectionOriginResource? ToEnum(string value)
        {
            return value switch
            {
                "environment" => McpConnectionOriginResource.Environment,
                "service" => McpConnectionOriginResource.Service,
                _ => null,
            };
        }
    }
}