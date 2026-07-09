
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.web_search_call.in_progress`.
    /// </summary>
    public enum BetaResponseWebSearchCallInProgressEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseWebSearchCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseWebSearchCallInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseWebSearchCallInProgressEventType value)
        {
            return value switch
            {
                BetaResponseWebSearchCallInProgressEventType.ResponseWebSearchCallInProgress => "response.web_search_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseWebSearchCallInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.web_search_call.in_progress" => BetaResponseWebSearchCallInProgressEventType.ResponseWebSearchCallInProgress,
                _ => null,
            };
        }
    }
}