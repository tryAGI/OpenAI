
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `compaction_trigger`.<br/>
    /// Default Value: compaction_trigger
    /// </summary>
    public enum CompactionTriggerItemParamType
    {
        /// <summary>
        /// 
        /// </summary>
        CompactionTrigger,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompactionTriggerItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompactionTriggerItemParamType value)
        {
            return value switch
            {
                CompactionTriggerItemParamType.CompactionTrigger => "compaction_trigger",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompactionTriggerItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "compaction_trigger" => CompactionTriggerItemParamType.CompactionTrigger,
                _ => null,
            };
        }
    }
}