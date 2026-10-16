
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: session.output_transcript.delta
    /// </summary>
    public enum LiveDecisionEventSourceEventTypeVariant1Variant2
    {
        /// <summary>
        ///
        /// </summary>
        SessionOutputTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionEventSourceEventTypeVariant1Variant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionEventSourceEventTypeVariant1Variant2 value)
        {
            return value switch
            {
                LiveDecisionEventSourceEventTypeVariant1Variant2.SessionOutputTranscriptDelta => "session.output_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionEventSourceEventTypeVariant1Variant2? ToEnum(string value)
        {
            return value switch
            {
                "session.output_transcript.delta" => LiveDecisionEventSourceEventTypeVariant1Variant2.SessionOutputTranscriptDelta,
                _ => null,
            };
        }
    }
}