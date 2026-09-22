
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, always `session.instructions.appended`.<br/>
    /// Default Value: session.instructions.appended
    /// </summary>
    public enum LiveInstructionsAppendedType
    {
        /// <summary>
        ///
        /// </summary>
        SessionInstructionsAppended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInstructionsAppendedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInstructionsAppendedType value)
        {
            return value switch
            {
                LiveInstructionsAppendedType.SessionInstructionsAppended => "session.instructions.appended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInstructionsAppendedType? ToEnum(string value)
        {
            return value switch
            {
                "session.instructions.appended" => LiveInstructionsAppendedType.SessionInstructionsAppended,
                _ => null,
            };
        }
    }
}