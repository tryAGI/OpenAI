
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `response.compaction`.<br/>
    /// Default Value: response.compaction
    /// </summary>
    public enum CompactResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCompaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompactResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompactResourceObject value)
        {
            return value switch
            {
                CompactResourceObject.ResponseCompaction => "response.compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompactResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "response.compaction" => CompactResourceObject.ResponseCompaction,
                _ => null,
            };
        }
    }
}