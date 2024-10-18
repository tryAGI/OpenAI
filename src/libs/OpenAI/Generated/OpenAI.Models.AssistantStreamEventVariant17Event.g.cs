
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant17Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunStepCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant17EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant17Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant17Event.ThreadRunStepCompleted => "thread.run.step.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant17Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.completed" => AssistantStreamEventVariant17Event.ThreadRunStepCompleted,
                _ => null,
            };
        }
    }
}