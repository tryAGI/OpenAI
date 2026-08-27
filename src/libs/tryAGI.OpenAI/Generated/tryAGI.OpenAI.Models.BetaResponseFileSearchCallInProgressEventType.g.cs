
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.file_search_call.in_progress`.
    /// </summary>
    public enum BetaResponseFileSearchCallInProgressEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFileSearchCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseFileSearchCallInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseFileSearchCallInProgressEventType value)
        {
            return value switch
            {
                BetaResponseFileSearchCallInProgressEventType.ResponseFileSearchCallInProgress => "response.file_search_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseFileSearchCallInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.file_search_call.in_progress" => BetaResponseFileSearchCallInProgressEventType.ResponseFileSearchCallInProgress,
                _ => null,
            };
        }
    }
}