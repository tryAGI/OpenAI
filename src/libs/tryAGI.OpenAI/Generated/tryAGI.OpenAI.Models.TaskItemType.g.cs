
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `chatkit.task`.<br/>
    /// Default Value: chatkit.task
    /// </summary>
    public enum TaskItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatkitTask,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskItemType value)
        {
            return value switch
            {
                TaskItemType.ChatkitTask => "chatkit.task",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskItemType? ToEnum(string value)
        {
            return value switch
            {
                "chatkit.task" => TaskItemType.ChatkitTask,
                _ => null,
            };
        }
    }
}