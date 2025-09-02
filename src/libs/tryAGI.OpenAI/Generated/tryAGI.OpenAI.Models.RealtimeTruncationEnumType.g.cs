
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Use retention ratio truncation.
    /// </summary>
    public enum RealtimeTruncationEnumType
    {
        /// <summary>
        /// 
        /// </summary>
        RetentionRatio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTruncationEnumTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTruncationEnumType value)
        {
            return value switch
            {
                RealtimeTruncationEnumType.RetentionRatio => "retention_ratio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTruncationEnumType? ToEnum(string value)
        {
            return value switch
            {
                "retention_ratio" => RealtimeTruncationEnumType.RetentionRatio,
                _ => null,
            };
        }
    }
}