
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `response.event`.<br/>
    /// Default Value: response.event
    /// </summary>
    public enum LiveResponseEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveResponseEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveResponseEventType value)
        {
            return value switch
            {
                LiveResponseEventType.ResponseEvent => "response.event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveResponseEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.event" => LiveResponseEventType.ResponseEvent,
                _ => null,
            };
        }
    }
}