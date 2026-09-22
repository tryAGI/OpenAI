
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The author of this history message. Always `assistant`.<br/>
    /// Default Value: assistant
    /// </summary>
    public enum LiveInitialAssistantMessageItemParamRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInitialAssistantMessageItemParamRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInitialAssistantMessageItemParamRole value)
        {
            return value switch
            {
                LiveInitialAssistantMessageItemParamRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInitialAssistantMessageItemParamRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => LiveInitialAssistantMessageItemParamRole.Assistant,
                _ => null,
            };
        }
    }
}