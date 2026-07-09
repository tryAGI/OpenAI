
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `response.compaction`.<br/>
    /// Default Value: response.compaction
    /// </summary>
    public enum BetaCompactResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCompaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCompactResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCompactResourceObject value)
        {
            return value switch
            {
                BetaCompactResourceObject.ResponseCompaction => "response.compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCompactResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "response.compaction" => BetaCompactResourceObject.ResponseCompaction,
                _ => null,
            };
        }
    }
}