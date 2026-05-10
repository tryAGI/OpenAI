
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ThreadItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatkitAssistantMessage,
        /// <summary>
        /// 
        /// </summary>
        ChatkitClientToolCall,
        /// <summary>
        /// 
        /// </summary>
        ChatkitTask,
        /// <summary>
        /// 
        /// </summary>
        ChatkitTaskGroup,
        /// <summary>
        /// 
        /// </summary>
        ChatkitUserMessage,
        /// <summary>
        /// 
        /// </summary>
        ChatkitWidget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThreadItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThreadItemDiscriminatorType value)
        {
            return value switch
            {
                ThreadItemDiscriminatorType.ChatkitAssistantMessage => "chatkit.assistant_message",
                ThreadItemDiscriminatorType.ChatkitClientToolCall => "chatkit.client_tool_call",
                ThreadItemDiscriminatorType.ChatkitTask => "chatkit.task",
                ThreadItemDiscriminatorType.ChatkitTaskGroup => "chatkit.task_group",
                ThreadItemDiscriminatorType.ChatkitUserMessage => "chatkit.user_message",
                ThreadItemDiscriminatorType.ChatkitWidget => "chatkit.widget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThreadItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "chatkit.assistant_message" => ThreadItemDiscriminatorType.ChatkitAssistantMessage,
                "chatkit.client_tool_call" => ThreadItemDiscriminatorType.ChatkitClientToolCall,
                "chatkit.task" => ThreadItemDiscriminatorType.ChatkitTask,
                "chatkit.task_group" => ThreadItemDiscriminatorType.ChatkitTaskGroup,
                "chatkit.user_message" => ThreadItemDiscriminatorType.ChatkitUserMessage,
                "chatkit.widget" => ThreadItemDiscriminatorType.ChatkitWidget,
                _ => null,
            };
        }
    }
}