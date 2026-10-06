
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: message
    /// </summary>
    public enum DecisionInputMessageType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputMessageType value)
        {
            return value switch
            {
                DecisionInputMessageType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputMessageType? ToEnum(string value)
        {
            return value switch
            {
                "message" => DecisionInputMessageType.Message,
                _ => null,
            };
        }
    }
}