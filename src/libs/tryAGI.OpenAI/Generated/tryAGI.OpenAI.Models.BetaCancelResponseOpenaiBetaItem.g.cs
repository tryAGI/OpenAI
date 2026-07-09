
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaCancelResponseOpenaiBetaItem
    {
        /// <summary>
        /// 
        /// </summary>
        ResponsesMultiAgent_v1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCancelResponseOpenaiBetaItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCancelResponseOpenaiBetaItem value)
        {
            return value switch
            {
                BetaCancelResponseOpenaiBetaItem.ResponsesMultiAgent_v1 => "responses_multi_agent=v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCancelResponseOpenaiBetaItem? ToEnum(string value)
        {
            return value switch
            {
                "responses_multi_agent=v1" => BetaCancelResponseOpenaiBetaItem.ResponsesMultiAgent_v1,
                _ => null,
            };
        }
    }
}