
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.web_search_call.completed`.
    /// </summary>
    public enum BetaResponseWebSearchCallCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseWebSearchCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseWebSearchCallCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseWebSearchCallCompletedEventType value)
        {
            return value switch
            {
                BetaResponseWebSearchCallCompletedEventType.ResponseWebSearchCallCompleted => "response.web_search_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseWebSearchCallCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.web_search_call.completed" => BetaResponseWebSearchCallCompletedEventType.ResponseWebSearchCallCompleted,
                _ => null,
            };
        }
    }
}