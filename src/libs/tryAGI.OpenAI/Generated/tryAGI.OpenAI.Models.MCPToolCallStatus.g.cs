
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
        Calling,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
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
                MCPToolCallStatus.Calling => "calling",
                MCPToolCallStatus.Completed => "completed",
                MCPToolCallStatus.Failed => "failed",
                MCPToolCallStatus.InProgress => "in_progress",
                MCPToolCallStatus.Incomplete => "incomplete",
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
                "calling" => MCPToolCallStatus.Calling,
                "completed" => MCPToolCallStatus.Completed,
                "failed" => MCPToolCallStatus.Failed,
                "in_progress" => MCPToolCallStatus.InProgress,
                "incomplete" => MCPToolCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}