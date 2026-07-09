
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `compaction`.<br/>
    /// Default Value: compaction
    /// </summary>
    public enum BetaCompactionBodyType
    {
        /// <summary>
        /// 
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCompactionBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCompactionBodyType value)
        {
            return value switch
            {
                BetaCompactionBodyType.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCompactionBodyType? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => BetaCompactionBodyType.Compaction,
                _ => null,
            };
        }
    }
}