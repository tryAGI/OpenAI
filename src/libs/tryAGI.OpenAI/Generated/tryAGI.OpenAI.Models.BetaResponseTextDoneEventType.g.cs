
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.output_text.done`.
    /// </summary>
    public enum BetaResponseTextDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseTextDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseTextDoneEventType value)
        {
            return value switch
            {
                BetaResponseTextDoneEventType.ResponseOutputTextDone => "response.output_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseTextDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.done" => BetaResponseTextDoneEventType.ResponseOutputTextDone,
                _ => null,
            };
        }
    }
}