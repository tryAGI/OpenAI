
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `session.thinking.appended`.<br/>
    /// Default Value: session.thinking.appended
    /// </summary>
    public enum LiveThinkingAppendedType
    {
        /// <summary>
        ///
        /// </summary>
        SessionThinkingAppended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveThinkingAppendedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveThinkingAppendedType value)
        {
            return value switch
            {
                LiveThinkingAppendedType.SessionThinkingAppended => "session.thinking.appended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveThinkingAppendedType? ToEnum(string value)
        {
            return value switch
            {
                "session.thinking.appended" => LiveThinkingAppendedType.SessionThinkingAppended,
                _ => null,
            };
        }
    }
}