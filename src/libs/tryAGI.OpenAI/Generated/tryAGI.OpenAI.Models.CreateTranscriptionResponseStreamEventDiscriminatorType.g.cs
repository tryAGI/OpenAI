
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTranscriptionResponseStreamEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        TranscriptTextDelta,
        /// <summary>
        /// 
        /// </summary>
        TranscriptTextDone,
        /// <summary>
        /// 
        /// </summary>
        TranscriptTextSegment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranscriptionResponseStreamEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranscriptionResponseStreamEventDiscriminatorType value)
        {
            return value switch
            {
                CreateTranscriptionResponseStreamEventDiscriminatorType.TranscriptTextDelta => "transcript.text.delta",
                CreateTranscriptionResponseStreamEventDiscriminatorType.TranscriptTextDone => "transcript.text.done",
                CreateTranscriptionResponseStreamEventDiscriminatorType.TranscriptTextSegment => "transcript.text.segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranscriptionResponseStreamEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "transcript.text.delta" => CreateTranscriptionResponseStreamEventDiscriminatorType.TranscriptTextDelta,
                "transcript.text.done" => CreateTranscriptionResponseStreamEventDiscriminatorType.TranscriptTextDone,
                "transcript.text.segment" => CreateTranscriptionResponseStreamEventDiscriminatorType.TranscriptTextSegment,
                _ => null,
            };
        }
    }
}