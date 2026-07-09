
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the message input. Always `message`.
    /// </summary>
    public enum BetaEasyInputMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaEasyInputMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaEasyInputMessageType value)
        {
            return value switch
            {
                BetaEasyInputMessageType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaEasyInputMessageType? ToEnum(string value)
        {
            return value switch
            {
                "message" => BetaEasyInputMessageType.Message,
                _ => null,
            };
        }
    }
}