
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum MCPToolCallErrorDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        HttpError,
        /// <summary>
        ///
        /// </summary>
        McpProtocolError,
        /// <summary>
        ///
        /// </summary>
        McpToolExecutionError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPToolCallErrorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolCallErrorDiscriminatorType value)
        {
            return value switch
            {
                MCPToolCallErrorDiscriminatorType.HttpError => "http_error",
                MCPToolCallErrorDiscriminatorType.McpProtocolError => "mcp_protocol_error",
                MCPToolCallErrorDiscriminatorType.McpToolExecutionError => "mcp_tool_execution_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolCallErrorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "http_error" => MCPToolCallErrorDiscriminatorType.HttpError,
                "mcp_protocol_error" => MCPToolCallErrorDiscriminatorType.McpProtocolError,
                "mcp_tool_execution_error" => MCPToolCallErrorDiscriminatorType.McpToolExecutionError,
                _ => null,
            };
        }
    }
}