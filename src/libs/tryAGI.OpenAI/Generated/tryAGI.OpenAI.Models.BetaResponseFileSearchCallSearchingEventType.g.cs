
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.file_search_call.searching`.
    /// </summary>
    public enum BetaResponseFileSearchCallSearchingEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFileSearchCallSearching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseFileSearchCallSearchingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseFileSearchCallSearchingEventType value)
        {
            return value switch
            {
                BetaResponseFileSearchCallSearchingEventType.ResponseFileSearchCallSearching => "response.file_search_call.searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseFileSearchCallSearchingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.file_search_call.searching" => BetaResponseFileSearchCallSearchingEventType.ResponseFileSearchCallSearching,
                _ => null,
            };
        }
    }
}