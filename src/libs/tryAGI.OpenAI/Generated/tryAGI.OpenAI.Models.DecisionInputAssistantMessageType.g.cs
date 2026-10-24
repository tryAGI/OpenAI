
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: message
    /// </summary>
    public enum DecisionInputAssistantMessageType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputAssistantMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputAssistantMessageType value)
        {
            return value switch
            {
                DecisionInputAssistantMessageType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputAssistantMessageType? ToEnum(string value)
        {
            return value switch
            {
                "message" => DecisionInputAssistantMessageType.Message,
                _ => null,
            };
        }
    }
}