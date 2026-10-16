
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionTriggerInputParamEventType
    {
        /// <summary>
        ///
        /// </summary>
        SessionInputTranscriptDelta,
        /// <summary>
        ///
        /// </summary>
        SessionOutputTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionTriggerInputParamEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionTriggerInputParamEventType value)
        {
            return value switch
            {
                LiveDecisionTriggerInputParamEventType.SessionInputTranscriptDelta => "session.input_transcript.delta",
                LiveDecisionTriggerInputParamEventType.SessionOutputTranscriptDelta => "session.output_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionTriggerInputParamEventType? ToEnum(string value)
        {
            return value switch
            {
                "session.input_transcript.delta" => LiveDecisionTriggerInputParamEventType.SessionInputTranscriptDelta,
                "session.output_transcript.delta" => LiveDecisionTriggerInputParamEventType.SessionOutputTranscriptDelta,
                _ => null,
            };
        }
    }
}