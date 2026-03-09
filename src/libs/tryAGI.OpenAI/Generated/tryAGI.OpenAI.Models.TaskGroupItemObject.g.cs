
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `chatkit.thread_item`.<br/>
    /// Default Value: chatkit.thread_item
    /// </summary>
    public enum TaskGroupItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        ChatkitThreadItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskGroupItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskGroupItemObject value)
        {
            return value switch
            {
                TaskGroupItemObject.ChatkitThreadItem => "chatkit.thread_item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskGroupItemObject? ToEnum(string value)
        {
            return value switch
            {
                "chatkit.thread_item" => TaskGroupItemObject.ChatkitThreadItem,
                _ => null,
            };
        }
    }
}