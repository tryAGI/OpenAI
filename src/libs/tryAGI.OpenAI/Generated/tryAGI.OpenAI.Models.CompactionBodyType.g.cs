
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `compaction`.<br/>
    /// Default Value: compaction
    /// </summary>
    public enum CompactionBodyType
    {
        /// <summary>
        /// 
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompactionBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompactionBodyType value)
        {
            return value switch
            {
                CompactionBodyType.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompactionBodyType? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => CompactionBodyType.Compaction,
                _ => null,
            };
        }
    }
}