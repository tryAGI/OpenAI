
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `session.commentary.appended`.<br/>
    /// Default Value: session.commentary.appended
    /// </summary>
    public enum LiveCommentaryAppendedType
    {
        /// <summary>
        ///
        /// </summary>
        SessionCommentaryAppended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveCommentaryAppendedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveCommentaryAppendedType value)
        {
            return value switch
            {
                LiveCommentaryAppendedType.SessionCommentaryAppended => "session.commentary.appended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveCommentaryAppendedType? ToEnum(string value)
        {
            return value switch
            {
                "session.commentary.appended" => LiveCommentaryAppendedType.SessionCommentaryAppended,
                _ => null,
            };
        }
    }
}