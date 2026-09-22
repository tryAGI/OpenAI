
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The Live client event type. Always `session.commentary.append`.<br/>
    /// Default Value: session.commentary.append
    /// </summary>
    public enum LiveCommentaryAppendParamType
    {
        /// <summary>
        ///
        /// </summary>
        SessionCommentaryAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveCommentaryAppendParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveCommentaryAppendParamType value)
        {
            return value switch
            {
                LiveCommentaryAppendParamType.SessionCommentaryAppend => "session.commentary.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveCommentaryAppendParamType? ToEnum(string value)
        {
            return value switch
            {
                "session.commentary.append" => LiveCommentaryAppendParamType.SessionCommentaryAppend,
                _ => null,
            };
        }
    }
}