
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.output_item.done`.
    /// </summary>
    public enum BetaResponseOutputItemDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputItemDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseOutputItemDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseOutputItemDoneEventType value)
        {
            return value switch
            {
                BetaResponseOutputItemDoneEventType.ResponseOutputItemDone => "response.output_item.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseOutputItemDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_item.done" => BetaResponseOutputItemDoneEventType.ResponseOutputItemDone,
                _ => null,
            };
        }
    }
}