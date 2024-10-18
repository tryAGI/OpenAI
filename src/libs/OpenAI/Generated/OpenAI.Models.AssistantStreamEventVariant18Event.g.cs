
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantStreamEventVariant18Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadRunStepFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantStreamEventVariant18EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantStreamEventVariant18Event value)
        {
            return value switch
            {
                AssistantStreamEventVariant18Event.ThreadRunStepFailed => "thread.run.step.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantStreamEventVariant18Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.run.step.failed" => AssistantStreamEventVariant18Event.ThreadRunStepFailed,
                _ => null,
            };
        }
    }
}