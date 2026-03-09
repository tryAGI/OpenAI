
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum TaskType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Thought,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskType value)
        {
            return value switch
            {
                TaskType.Custom => "custom",
                TaskType.Thought => "thought",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => TaskType.Custom,
                "thought" => TaskType.Thought,
                _ => null,
            };
        }
    }
}