
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.web_search_call.searching`.
    /// </summary>
    public enum BetaResponseWebSearchCallSearchingEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseWebSearchCallSearching,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseWebSearchCallSearchingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseWebSearchCallSearchingEventType value)
        {
            return value switch
            {
                BetaResponseWebSearchCallSearchingEventType.ResponseWebSearchCallSearching => "response.web_search_call.searching",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseWebSearchCallSearchingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.web_search_call.searching" => BetaResponseWebSearchCallSearchingEventType.ResponseWebSearchCallSearching,
                _ => null,
            };
        }
    }
}