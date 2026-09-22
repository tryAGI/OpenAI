
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaMCPToolCallErrorDiscriminatorType
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
    public static class BetaMCPToolCallErrorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMCPToolCallErrorDiscriminatorType value)
        {
            return value switch
            {
                BetaMCPToolCallErrorDiscriminatorType.HttpError => "http_error",
                BetaMCPToolCallErrorDiscriminatorType.McpProtocolError => "mcp_protocol_error",
                BetaMCPToolCallErrorDiscriminatorType.McpToolExecutionError => "mcp_tool_execution_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMCPToolCallErrorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "http_error" => BetaMCPToolCallErrorDiscriminatorType.HttpError,
                "mcp_protocol_error" => BetaMCPToolCallErrorDiscriminatorType.McpProtocolError,
                "mcp_tool_execution_error" => BetaMCPToolCallErrorDiscriminatorType.McpToolExecutionError,
                _ => null,
            };
        }
    }
}