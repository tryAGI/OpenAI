
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event discriminator. Always `response.inject`.
    /// </summary>
    public enum BetaResponseInjectEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseInject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseInjectEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseInjectEventType value)
        {
            return value switch
            {
                BetaResponseInjectEventType.ResponseInject => "response.inject",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseInjectEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.inject" => BetaResponseInjectEventType.ResponseInject,
                _ => null,
            };
        }
    }
}