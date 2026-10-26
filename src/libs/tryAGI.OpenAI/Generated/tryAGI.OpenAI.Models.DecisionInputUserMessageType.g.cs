
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: message
    /// </summary>
    public enum DecisionInputUserMessageType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputUserMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputUserMessageType value)
        {
            return value switch
            {
                DecisionInputUserMessageType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputUserMessageType? ToEnum(string value)
        {
            return value switch
            {
                "message" => DecisionInputUserMessageType.Message,
                _ => null,
            };
        }
    }
}