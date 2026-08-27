
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetinputtokencountsOpenaiBetaItem
    {
        /// <summary>
        ///
        /// </summary>
        ResponsesMultiAgent_v1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGetinputtokencountsOpenaiBetaItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetinputtokencountsOpenaiBetaItem value)
        {
            return value switch
            {
                BetaGetinputtokencountsOpenaiBetaItem.ResponsesMultiAgent_v1 => "responses_multi_agent=v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetinputtokencountsOpenaiBetaItem? ToEnum(string value)
        {
            return value switch
            {
                "responses_multi_agent=v1" => BetaGetinputtokencountsOpenaiBetaItem.ResponsesMultiAgent_v1,
                _ => null,
            };
        }
    }
}