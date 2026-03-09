
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the segment. Always `transcript.text.segment`.
    /// </summary>
    public enum TranscriptionDiarizedSegmentType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptTextSegment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionDiarizedSegmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionDiarizedSegmentType value)
        {
            return value switch
            {
                TranscriptionDiarizedSegmentType.TranscriptTextSegment => "transcript.text.segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionDiarizedSegmentType? ToEnum(string value)
        {
            return value switch
            {
                "transcript.text.segment" => TranscriptionDiarizedSegmentType.TranscriptTextSegment,
                _ => null,
            };
        }
    }
}