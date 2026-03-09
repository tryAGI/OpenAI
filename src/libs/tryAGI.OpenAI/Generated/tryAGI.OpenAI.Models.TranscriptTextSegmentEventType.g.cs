
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `transcript.text.segment`.
    /// </summary>
    public enum TranscriptTextSegmentEventType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptTextSegment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptTextSegmentEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptTextSegmentEventType value)
        {
            return value switch
            {
                TranscriptTextSegmentEventType.TranscriptTextSegment => "transcript.text.segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptTextSegmentEventType? ToEnum(string value)
        {
            return value switch
            {
                "transcript.text.segment" => TranscriptTextSegmentEventType.TranscriptTextSegment,
                _ => null,
            };
        }
    }
}