
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The Live client event type. Always `session.thinking.append`.<br/>
    /// Default Value: session.thinking.append
    /// </summary>
    public enum LiveThinkingAppendParamType
    {
        /// <summary>
        ///
        /// </summary>
        SessionThinkingAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveThinkingAppendParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveThinkingAppendParamType value)
        {
            return value switch
            {
                LiveThinkingAppendParamType.SessionThinkingAppend => "session.thinking.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveThinkingAppendParamType? ToEnum(string value)
        {
            return value switch
            {
                "session.thinking.append" => LiveThinkingAppendParamType.SessionThinkingAppend,
                _ => null,
            };
        }
    }
}