
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionTriggerInputParam2EventType
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
    public static class LiveDecisionTriggerInputParam2EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionTriggerInputParam2EventType value)
        {
            return value switch
            {
                LiveDecisionTriggerInputParam2EventType.SessionInputTranscriptDelta => "session.input_transcript.delta",
                LiveDecisionTriggerInputParam2EventType.SessionOutputTranscriptDelta => "session.output_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionTriggerInputParam2EventType? ToEnum(string value)
        {
            return value switch
            {
                "session.input_transcript.delta" => LiveDecisionTriggerInputParam2EventType.SessionInputTranscriptDelta,
                "session.output_transcript.delta" => LiveDecisionTriggerInputParam2EventType.SessionOutputTranscriptDelta,
                _ => null,
            };
        }
    }
}