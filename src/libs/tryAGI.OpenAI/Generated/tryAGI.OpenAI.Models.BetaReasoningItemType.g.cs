
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `reasoning`.
    /// </summary>
    public enum BetaReasoningItemType
    {
        /// <summary>
        ///
        /// </summary>
        Reasoning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaReasoningItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaReasoningItemType value)
        {
            return value switch
            {
                BetaReasoningItemType.Reasoning => "reasoning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaReasoningItemType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning" => BetaReasoningItemType.Reasoning,
                _ => null,
            };
        }
    }
}