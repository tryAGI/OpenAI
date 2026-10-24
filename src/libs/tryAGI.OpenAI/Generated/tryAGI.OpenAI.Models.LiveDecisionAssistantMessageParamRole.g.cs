
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: assistant
    /// </summary>
    public enum LiveDecisionAssistantMessageParamRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionAssistantMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionAssistantMessageParamRole value)
        {
            return value switch
            {
                LiveDecisionAssistantMessageParamRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionAssistantMessageParamRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => LiveDecisionAssistantMessageParamRole.Assistant,
                _ => null,
            };
        }
    }
}