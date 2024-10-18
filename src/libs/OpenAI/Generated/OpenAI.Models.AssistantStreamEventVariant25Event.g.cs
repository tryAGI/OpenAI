
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant25Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadMessageIncomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant25EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant25Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant25Event.ThreadMessageIncomplete => "thread.message.incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant25Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.message.incomplete" => AssistantStreamEventVariant25Event.ThreadMessageIncomplete,
                _ => null,
            };
        }
    }
}