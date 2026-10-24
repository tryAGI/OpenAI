
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: assistant
    /// </summary>
    public enum DecisionInputAssistantMessageRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputAssistantMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputAssistantMessageRole value)
        {
            return value switch
            {
                DecisionInputAssistantMessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputAssistantMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => DecisionInputAssistantMessageRole.Assistant,
                _ => null,
            };
        }
    }
}