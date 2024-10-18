
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant24Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadMessageCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant24EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant24Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant24Event.ThreadMessageCompleted => "thread.message.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant24Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.message.completed" => AssistantStreamEventVariant24Event.ThreadMessageCompleted,
                _ => null,
            };
        }
    }
}