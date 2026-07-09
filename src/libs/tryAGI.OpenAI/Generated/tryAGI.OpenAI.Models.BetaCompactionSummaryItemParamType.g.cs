
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `compaction`.<br/>
    /// Default Value: compaction
    /// </summary>
    public enum BetaCompactionSummaryItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCompactionSummaryItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCompactionSummaryItemParamType value)
        {
            return value switch
            {
                BetaCompactionSummaryItemParamType.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCompactionSummaryItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => BetaCompactionSummaryItemParamType.Compaction,
                _ => null,
            };
        }
    }
}