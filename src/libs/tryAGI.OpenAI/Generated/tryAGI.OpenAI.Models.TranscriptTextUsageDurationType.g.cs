
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the usage object. Always `duration` for this variant.
    /// </summary>
    public enum TranscriptTextUsageDurationType
    {
        /// <summary>
        /// 
        /// </summary>
        Duration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptTextUsageDurationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptTextUsageDurationType value)
        {
            return value switch
            {
                TranscriptTextUsageDurationType.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptTextUsageDurationType? ToEnum(string value)
        {
            return value switch
            {
                "duration" => TranscriptTextUsageDurationType.Duration,
                _ => null,
            };
        }
    }
}