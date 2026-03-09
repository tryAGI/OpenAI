
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum MCPToolCallStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        Calling,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolCallStatus value)
        {
            return value switch
            {
                MCPToolCallStatus.InProgress => "in_progress",
                MCPToolCallStatus.Completed => "completed",
                MCPToolCallStatus.Incomplete => "incomplete",
                MCPToolCallStatus.Calling => "calling",
                MCPToolCallStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => MCPToolCallStatus.InProgress,
                "completed" => MCPToolCallStatus.Completed,
                "incomplete" => MCPToolCallStatus.Incomplete,
                "calling" => MCPToolCallStatus.Calling,
                "failed" => MCPToolCallStatus.Failed,
                _ => null,
            };
        }
    }
}