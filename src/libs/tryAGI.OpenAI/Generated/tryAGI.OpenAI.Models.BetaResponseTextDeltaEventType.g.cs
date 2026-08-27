
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.output_text.delta`.
    /// </summary>
    public enum BetaResponseTextDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseTextDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseTextDeltaEventType value)
        {
            return value switch
            {
                BetaResponseTextDeltaEventType.ResponseOutputTextDelta => "response.output_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseTextDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.delta" => BetaResponseTextDeltaEventType.ResponseOutputTextDelta,
                _ => null,
            };
        }
    }
}