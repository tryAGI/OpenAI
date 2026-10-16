
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: session.input_transcript.delta
    /// </summary>
    public enum LiveDecisionEventSourceEventTypeVariant1Variant1
    {
        /// <summary>
        ///
        /// </summary>
        SessionInputTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionEventSourceEventTypeVariant1Variant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionEventSourceEventTypeVariant1Variant1 value)
        {
            return value switch
            {
                LiveDecisionEventSourceEventTypeVariant1Variant1.SessionInputTranscriptDelta => "session.input_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionEventSourceEventTypeVariant1Variant1? ToEnum(string value)
        {
            return value switch
            {
                "session.input_transcript.delta" => LiveDecisionEventSourceEventTypeVariant1Variant1.SessionInputTranscriptDelta,
                _ => null,
            };
        }
    }
}