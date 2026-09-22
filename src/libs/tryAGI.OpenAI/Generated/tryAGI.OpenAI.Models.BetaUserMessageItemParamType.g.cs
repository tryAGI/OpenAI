
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `message`.<br/>
    /// Default Value: message
    /// </summary>
    public enum BetaUserMessageItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaUserMessageItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUserMessageItemParamType value)
        {
            return value switch
            {
                BetaUserMessageItemParamType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUserMessageItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "message" => BetaUserMessageItemParamType.Message,
                _ => null,
            };
        }
    }
}