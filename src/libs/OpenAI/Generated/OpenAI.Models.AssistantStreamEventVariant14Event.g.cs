
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant14Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunStepCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant14EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant14Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant14Event.ThreadRunStepCreated => "thread.run.step.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant14Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.created" => AssistantStreamEventVariant14Event.ThreadRunStepCreated,
                _ => null,
            };
        }
    }
}