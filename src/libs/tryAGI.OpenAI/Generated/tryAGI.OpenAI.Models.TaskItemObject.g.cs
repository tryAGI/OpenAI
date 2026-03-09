
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `chatkit.thread_item`.<br/>
    /// Default Value: chatkit.thread_item
    /// </summary>
    public enum TaskItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        ChatkitThreadItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskItemObject value)
        {
            return value switch
            {
                TaskItemObject.ChatkitThreadItem => "chatkit.thread_item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskItemObject? ToEnum(string value)
        {
            return value switch
            {
                "chatkit.thread_item" => TaskItemObject.ChatkitThreadItem,
                _ => null,
            };
        }
    }
}