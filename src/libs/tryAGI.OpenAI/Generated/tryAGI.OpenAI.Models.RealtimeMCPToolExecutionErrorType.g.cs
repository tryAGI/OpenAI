
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeMCPToolExecutionErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolExecutionError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeMCPToolExecutionErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeMCPToolExecutionErrorType value)
        {
            return value switch
            {
                RealtimeMCPToolExecutionErrorType.ToolExecutionError => "tool_execution_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeMCPToolExecutionErrorType? ToEnum(string value)
        {
            return value switch
            {
                "tool_execution_error" => RealtimeMCPToolExecutionErrorType.ToolExecutionError,
                _ => null,
            };
        }
    }
}