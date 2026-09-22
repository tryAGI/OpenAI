
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The Live client event type. Always `session.instructions.append`.<br/>
    /// Default Value: session.instructions.append
    /// </summary>
    public enum LiveInstructionsAppendParamType
    {
        /// <summary>
        ///
        /// </summary>
        SessionInstructionsAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInstructionsAppendParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInstructionsAppendParamType value)
        {
            return value switch
            {
                LiveInstructionsAppendParamType.SessionInstructionsAppend => "session.instructions.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInstructionsAppendParamType? ToEnum(string value)
        {
            return value switch
            {
                "session.instructions.append" => LiveInstructionsAppendParamType.SessionInstructionsAppend,
                _ => null,
            };
        }
    }
}