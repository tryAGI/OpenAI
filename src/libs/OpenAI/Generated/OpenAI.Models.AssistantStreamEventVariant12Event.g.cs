
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant12Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunCancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant12EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant12Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant12Event.ThreadRunCancelled => "thread.run.cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant12Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.cancelled" => AssistantStreamEventVariant12Event.ThreadRunCancelled,
                _ => null,
            };
        }
    }
}