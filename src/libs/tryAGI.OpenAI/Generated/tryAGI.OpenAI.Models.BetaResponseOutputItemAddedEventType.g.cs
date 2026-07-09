
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.output_item.added`.
    /// </summary>
    public enum BetaResponseOutputItemAddedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseOutputItemAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseOutputItemAddedEventType value)
        {
            return value switch
            {
                BetaResponseOutputItemAddedEventType.ResponseOutputItemAdded => "response.output_item.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseOutputItemAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.added" => BetaResponseOutputItemAddedEventType.ResponseOutputItemAdded,
                _ => null,
            };
        }
    }
}