
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `session.output_transcript.delta`.<br/>
    /// Default Value: session.output_transcript.delta
    /// </summary>
    public enum LiveOutputTranscriptDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        SessionOutputTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveOutputTranscriptDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveOutputTranscriptDeltaType value)
        {
            return value switch
            {
                LiveOutputTranscriptDeltaType.SessionOutputTranscriptDelta => "session.output_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveOutputTranscriptDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "session.output_transcript.delta" => LiveOutputTranscriptDeltaType.SessionOutputTranscriptDelta,
                _ => null,
            };
        }
    }
}