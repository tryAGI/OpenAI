
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `session.input_transcript.delta`.<br/>
    /// Default Value: session.input_transcript.delta
    /// </summary>
    public enum LiveInputTranscriptDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        SessionInputTranscriptDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInputTranscriptDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInputTranscriptDeltaType value)
        {
            return value switch
            {
                LiveInputTranscriptDeltaType.SessionInputTranscriptDelta => "session.input_transcript.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInputTranscriptDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "session.input_transcript.delta" => LiveInputTranscriptDeltaType.SessionInputTranscriptDelta,
                _ => null,
            };
        }
    }
}