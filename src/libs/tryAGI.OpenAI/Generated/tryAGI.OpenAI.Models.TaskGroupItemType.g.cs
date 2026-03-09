
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `chatkit.task_group`.<br/>
    /// Default Value: chatkit.task_group
    /// </summary>
    public enum TaskGroupItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatkitTaskGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskGroupItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskGroupItemType value)
        {
            return value switch
            {
                TaskGroupItemType.ChatkitTaskGroup => "chatkit.task_group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskGroupItemType? ToEnum(string value)
        {
            return value switch
            {
                "chatkit.task_group" => TaskGroupItemType.ChatkitTaskGroup,
                _ => null,
            };
        }
    }
}