
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `compaction_trigger`.<br/>
    /// Default Value: compaction_trigger
    /// </summary>
    public enum BetaCompactionTriggerItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        CompactionTrigger,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCompactionTriggerItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCompactionTriggerItemParamType value)
        {
            return value switch
            {
                BetaCompactionTriggerItemParamType.CompactionTrigger => "compaction_trigger",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCompactionTriggerItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "compaction_trigger" => BetaCompactionTriggerItemParamType.CompactionTrigger,
                _ => null,
            };
        }
    }
}