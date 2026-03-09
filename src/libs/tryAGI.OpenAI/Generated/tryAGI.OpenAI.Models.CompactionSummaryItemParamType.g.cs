
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `compaction`.<br/>
    /// Default Value: compaction
    /// </summary>
    public enum CompactionSummaryItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompactionSummaryItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompactionSummaryItemParamType value)
        {
            return value switch
            {
                CompactionSummaryItemParamType.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompactionSummaryItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => CompactionSummaryItemParamType.Compaction,
                _ => null,
            };
        }
    }
}