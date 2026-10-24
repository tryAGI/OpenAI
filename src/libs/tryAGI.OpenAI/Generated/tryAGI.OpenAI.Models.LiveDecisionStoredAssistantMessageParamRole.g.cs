
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: assistant
    /// </summary>
    public enum LiveDecisionStoredAssistantMessageParamRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionStoredAssistantMessageParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredAssistantMessageParamRole value)
        {
            return value switch
            {
                LiveDecisionStoredAssistantMessageParamRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredAssistantMessageParamRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => LiveDecisionStoredAssistantMessageParamRole.Assistant,
                _ => null,
            };
        }
    }
}