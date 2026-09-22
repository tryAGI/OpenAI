
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The history item type. Always `message`.<br/>
    /// Default Value: message
    /// </summary>
    public enum LiveInitialAssistantMessageItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInitialAssistantMessageItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInitialAssistantMessageItemParamType value)
        {
            return value switch
            {
                LiveInitialAssistantMessageItemParamType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInitialAssistantMessageItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "message" => LiveInitialAssistantMessageItemParamType.Message,
                _ => null,
            };
        }
    }
}