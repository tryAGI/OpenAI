
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant8Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant8EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant8Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant8Event.ThreadRunCompleted => "thread.run.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant8Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.completed" => AssistantStreamEventVariant8Event.ThreadRunCompleted,
                _ => null,
            };
        }
    }
}