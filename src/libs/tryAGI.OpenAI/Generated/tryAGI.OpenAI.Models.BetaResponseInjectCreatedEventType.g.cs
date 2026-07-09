
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event discriminator. Always `response.inject.created`.
    /// </summary>
    public enum BetaResponseInjectCreatedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseInjectCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseInjectCreatedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseInjectCreatedEventType value)
        {
            return value switch
            {
                BetaResponseInjectCreatedEventType.ResponseInjectCreated => "response.inject.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseInjectCreatedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.inject.created" => BetaResponseInjectCreatedEventType.ResponseInjectCreated,
                _ => null,
            };
        }
    }
}