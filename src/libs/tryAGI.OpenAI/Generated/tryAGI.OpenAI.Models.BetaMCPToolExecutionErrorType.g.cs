
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: mcp_tool_execution_error
    /// </summary>
    public enum BetaMCPToolExecutionErrorType
    {
        /// <summary>
        ///
        /// </summary>
        McpToolExecutionError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMCPToolExecutionErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMCPToolExecutionErrorType value)
        {
            return value switch
            {
                BetaMCPToolExecutionErrorType.McpToolExecutionError => "mcp_tool_execution_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMCPToolExecutionErrorType? ToEnum(string value)
        {
            return value switch
            {
                "mcp_tool_execution_error" => BetaMCPToolExecutionErrorType.McpToolExecutionError,
                _ => null,
            };
        }
    }
}