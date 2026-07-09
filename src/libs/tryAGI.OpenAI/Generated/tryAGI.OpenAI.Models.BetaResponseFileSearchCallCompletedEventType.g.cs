
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.file_search_call.completed`.
    /// </summary>
    public enum BetaResponseFileSearchCallCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseFileSearchCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseFileSearchCallCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseFileSearchCallCompletedEventType value)
        {
            return value switch
            {
                BetaResponseFileSearchCallCompletedEventType.ResponseFileSearchCallCompleted => "response.file_search_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseFileSearchCallCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.file_search_call.completed" => BetaResponseFileSearchCallCompletedEventType.ResponseFileSearchCallCompleted,
                _ => null,
            };
        }
    }
}